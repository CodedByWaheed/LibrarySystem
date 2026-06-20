using Microsoft.Data.SqlClient;
using System;
using System.Data;

namespace LibrarySystem_DL
{
    public enum enLoanStatus { Active = 1, Extended = 2, Returned = 3, Lost = 4, Damaged = 5 }

    public class LoanDTO
    {
        public LoanDTO() { }

        public LoanDTO(int? loanID, int? userID, int? copyID, DateTime? loanDate,
            DateTime? dueDate, DateTime? returnDate, byte? extensionsCount,
            byte? maxExtensions, enLoanStatus? status, DateTime? createdAt)
        {
            LoanID = loanID;
            UserID = userID;
            CopyID = copyID;
            LoanDate = loanDate;
            DueDate = dueDate;
            ReturnDate = returnDate;
            ExtensionsCount = extensionsCount;
            MaxExtensions = maxExtensions;
            Status = status;
            CreatedAt = createdAt;
        }

        public int? LoanID { get; set; }
        public int? UserID { get; set; }
        public int? CopyID { get; set; }
        public DateTime? LoanDate { get; set; }
        public DateTime? DueDate { get; set; }
        public DateTime? ReturnDate { get; set; }
        public byte? ExtensionsCount { get; set; }
        public byte? MaxExtensions { get; set; }
        public enLoanStatus? Status { get; set; }
        public DateTime? CreatedAt { get; set; }

        // Read-only — populated by SP_Loan_GetByID (joined data)
        public string? FullName { get; set; }
        public string? Email { get; set; }
        public string? Title { get; set; }
        public string? ISBN { get; set; }
        public string? Barcode { get; set; }
        public string? ShelfLocation { get; set; }
        public int? DaysOverdue { get; set; }
    }

    public class LoansData
    {
        // =====================================================================
        // Private helpers
        // =====================================================================

        private static LoanDTO _MapReaderToLoan(SqlDataReader reader)
        {
            var loan = new LoanDTO
            {
                LoanID = reader["LoanID"] as int?,
            };

            if (_HasColumn(reader, "UserID") && reader["UserID"] != DBNull.Value)
                loan.UserID = Convert.ToInt32(reader["UserID"]);

            if (_HasColumn(reader, "CopyID") && reader["CopyID"] != DBNull.Value)
                loan.CopyID = Convert.ToInt32(reader["CopyID"]);

            if (_HasColumn(reader, "LoanDate"))
                loan.LoanDate = reader["LoanDate"] as DateTime?;

            if (_HasColumn(reader, "DueDate"))
                loan.DueDate = reader["DueDate"] as DateTime?;

            if (_HasColumn(reader, "ReturnDate"))
                loan.ReturnDate = reader["ReturnDate"] as DateTime?;

            if (_HasColumn(reader, "ExtensionsCount") && reader["ExtensionsCount"] != DBNull.Value)
                loan.ExtensionsCount = Convert.ToByte(reader["ExtensionsCount"]);

            // tinyint Status column — cast through byte, never `as enLoanStatus?`
            if (_HasColumn(reader, "Status") && reader["Status"] != DBNull.Value)
                loan.Status = (enLoanStatus)Convert.ToByte(reader["Status"]);

            // Joined columns — present on SP_Loan_GetByID only
            if (_HasColumn(reader, "FullName"))
                loan.FullName = reader["FullName"] as string;

            if (_HasColumn(reader, "Email"))
                loan.Email = reader["Email"] as string;

            if (_HasColumn(reader, "Title"))
                loan.Title = reader["Title"] as string;

            if (_HasColumn(reader, "ISBN"))
                loan.ISBN = reader["ISBN"] as string;

            if (_HasColumn(reader, "Barcode"))
                loan.Barcode = reader["Barcode"] as string;

            if (_HasColumn(reader, "ShelfLocation"))
                loan.ShelfLocation = reader["ShelfLocation"] as string;

            if (_HasColumn(reader, "DaysOverdue") && reader["DaysOverdue"] != DBNull.Value)
                loan.DaysOverdue = Convert.ToInt32(reader["DaysOverdue"]);

            return loan;
        }

        private static bool _HasColumn(SqlDataReader reader, string columnName)
        {
            for (int i = 0; i < reader.FieldCount; i++)
            {
                if (reader.GetName(i).Equals(columnName, StringComparison.OrdinalIgnoreCase))
                    return true;
            }
            return false;
        }

        // =====================================================================
        // ISSUE
        // =====================================================================

        /// <summary>
        /// Calls SP_Loan_Issue. Returns the new LoanID on success, or null if blocked
        /// (inactive user, unavailable copy, borrow limit reached, or unpaid fines —
        /// the SP RAISERROR's a specific message for each case, surfaced via SqlException).
        /// </summary>
        public static int? IssueLoan(int userID, int copyID, out string? errorMessage, int loanDays = 14)
        {
            int? newLoanID = null;
            errorMessage = null;

            using (SqlConnection connection = clsDataAccessSettings.GetConnection())
            using (SqlCommand command = new SqlCommand("SP_Loan_Issue", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@UserID", userID);
                command.Parameters.AddWithValue("@CopyID", copyID);
                command.Parameters.AddWithValue("@LoanDays", loanDays);

                SqlParameter outputIdParam = new SqlParameter("@NewLoanID", SqlDbType.Int)
                {
                    Direction = ParameterDirection.Output
                };
                command.Parameters.Add(outputIdParam);

                SqlParameter returnValue = new SqlParameter
                {
                    Direction = ParameterDirection.ReturnValue,
                    SqlDbType = SqlDbType.Int
                };
                command.Parameters.Add(returnValue);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();

                    int code = returnValue.Value != DBNull.Value ? (int)returnValue.Value : 0;
                    if (code > 0 && outputIdParam.Value != DBNull.Value)
                        newLoanID = (int)outputIdParam.Value;
                }
                catch (SqlException ex)
                {
                    // RAISERROR messages bubble up here, e.g. "User has reached the maximum borrow limit."
                    errorMessage = ex.Message;
                    Console.WriteLine("IssueLoan error: " + ex.Message);
                }
            }

            return newLoanID;
        }

        // =====================================================================
        // RETURN
        // =====================================================================

        /// <summary>
        /// Calls SP_Loan_Return. Setting ReturnDate fires trg_loans_on_return, which
        /// calculates any late fine, frees the copy, and marks the loan as returned.
        /// </summary>
        public static bool ReturnLoan(int loanID, out string? errorMessage)
        {
            bool isReturned = false;
            errorMessage = null;

            using (SqlConnection connection = clsDataAccessSettings.GetConnection())
            using (SqlCommand command = new SqlCommand("SP_Loan_Return", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@LoanID", loanID);

                SqlParameter returnValue = new SqlParameter
                {
                    Direction = ParameterDirection.ReturnValue,
                    SqlDbType = SqlDbType.Int
                };
                command.Parameters.Add(returnValue);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();

                    int code = returnValue.Value != DBNull.Value ? (int)returnValue.Value : 0;
                    isReturned = code >= 0;  // -1 = loan not found/already closed
                }
                catch (SqlException ex)
                {
                    errorMessage = ex.Message;
                    Console.WriteLine("ReturnLoan error: " + ex.Message);
                }
            }

            return isReturned;
        }

        // =====================================================================
        // EXTEND
        // =====================================================================

        /// <summary>
        /// Calls SP_Loan_Extend. Fails if max extensions reached, loan not active,
        /// or another member is waiting on a reservation for this book.
        /// </summary>
        public static bool ExtendLoan(int loanID, out string? errorMessage, int extendDays = 7)
        {
            bool isExtended = false;
            errorMessage = null;

            using (SqlConnection connection = clsDataAccessSettings.GetConnection())
            using (SqlCommand command = new SqlCommand("SP_Loan_Extend", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@LoanID", loanID);
                command.Parameters.AddWithValue("@ExtendDays", extendDays);

                SqlParameter returnValue = new SqlParameter
                {
                    Direction = ParameterDirection.ReturnValue,
                    SqlDbType = SqlDbType.Int
                };
                command.Parameters.Add(returnValue);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();

                    int code = returnValue.Value != DBNull.Value ? (int)returnValue.Value : 0;
                    isExtended = code == 0;  // see NOTE above — bare RETURN defaults to 0, same as "fell through"
                }
                catch (SqlException ex)
                {
                    errorMessage = ex.Message;
                    Console.WriteLine("ExtendLoan error: " + ex.Message);
                }
            }

            return isExtended;
        }

        // =====================================================================
        // READ
        // =====================================================================

        /// <summary>
        /// Calls SP_Loan_GetByID. Returns null if not found.
        /// </summary>
        public static LoanDTO? GetLoanById(int loanID)
        {
            LoanDTO? loan = null;

            using (SqlConnection connection = clsDataAccessSettings.GetConnection())
            using (SqlCommand command = new SqlCommand("SP_Loan_GetByID", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@LoanID", loanID);

                try
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            loan = _MapReaderToLoan(reader);
                        }
                    }
                }
                catch (SqlException ex)
                {
                    Console.WriteLine("GetLoanById error: " + ex.Message);
                }
            }

            return loan;
        }
    }
}
