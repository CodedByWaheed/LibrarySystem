using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace LibrarySystem_DL
{
    public enum enFineType { LateReturn = 1, LostBook = 2, DamagedBook = 3 }
    public enum enFineStatus { Pending = 1, Paid = 2, Waived = 3 }

    public class FineDTO
    {
        public FineDTO() { }

        public FineDTO(int? fineID, int? loanID, int? userID, enFineType? fineType,
            decimal? amount, enFineStatus? status, string? waivedReason, int? waivedBy,
            DateTime? issuedAt, DateTime? paidAt)
        {
            FineID = fineID;
            LoanID = loanID;
            UserID = userID;
            FineType = fineType;
            Amount = amount;
            Status = status;
            WaivedReason = waivedReason;
            WaivedBy = waivedBy;
            IssuedAt = issuedAt;
            PaidAt = paidAt;
        }

        public int? FineID { get; set; }
        public int? LoanID { get; set; }
        public int? UserID { get; set; }
        public enFineType? FineType { get; set; }
        public decimal? Amount { get; set; }
        public enFineStatus? Status { get; set; }
        public string? WaivedReason { get; set; }
        public int? WaivedBy { get; set; }
        public DateTime? IssuedAt { get; set; }
        public DateTime? PaidAt { get; set; }

        // Read-only — populated by SP_Fine_GetByUser
        public string? BookTitle { get; set; }
    }

    public class FinesData
    {
        // =====================================================================
        // Private helpers
        // =====================================================================

        private static FineDTO _MapReaderToFine(SqlDataReader reader)
        {
            var fine = new FineDTO
            {
                FineID = reader["FineID"] as int?,
                Amount = reader["Amount"] as decimal?,
            };

            // tinyint columns — cast through byte, never `as enFineType?`
            if (_HasColumn(reader, "FineType") && reader["FineType"] != DBNull.Value)
                fine.FineType = (enFineType)Convert.ToByte(reader["FineType"]);

            if (_HasColumn(reader, "Status") && reader["Status"] != DBNull.Value)
                fine.Status = (enFineStatus)Convert.ToByte(reader["Status"]);

            if (_HasColumn(reader, "IssuedAt"))
                fine.IssuedAt = reader["IssuedAt"] as DateTime?;

            if (_HasColumn(reader, "PaidAt"))
                fine.PaidAt = reader["PaidAt"] as DateTime?;

            if (_HasColumn(reader, "LoanID") && reader["LoanID"] != DBNull.Value)
                fine.LoanID = Convert.ToInt32(reader["LoanID"]);

            if (_HasColumn(reader, "UserID") && reader["UserID"] != DBNull.Value)
                fine.UserID = Convert.ToInt32(reader["UserID"]);

            if (_HasColumn(reader, "WaivedReason"))
                fine.WaivedReason = reader["WaivedReason"] as string;

            if (_HasColumn(reader, "WaivedBy") && reader["WaivedBy"] != DBNull.Value)
                fine.WaivedBy = Convert.ToInt32(reader["WaivedBy"]);

            // Joined column — present on SP_Fine_GetByUser only
            if (_HasColumn(reader, "BookTitle"))
                fine.BookTitle = reader["BookTitle"] as string;

            return fine;
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
        // READ
        // =====================================================================

        /// <summary>
        /// Calls SP_Fine_GetByUser. Returns the full fine history for one member,
        /// newest first.
        /// </summary>
        public static List<FineDTO> GetFinesByUser(int userID)
        {
            List<FineDTO> fines = new List<FineDTO>();

            using (SqlConnection connection = clsDataAccessSettings.GetConnection())
            using (SqlCommand command = new SqlCommand("SP_Fine_GetByUser", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@UserID", userID);

                try
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            fines.Add(_MapReaderToFine(reader));
                        }
                    }
                }
                catch (SqlException ex)
                {
                    Console.WriteLine("GetFinesByUser error: " + ex.Message);
                }
            }

            return fines;
        }

        // =====================================================================
        // UPDATE — pay
        // =====================================================================

        /// <summary>
        /// Calls SP_Fine_Pay. Marks a pending fine as paid. Returns false if the
        /// fine doesn't exist
        /// </summary>
        public static bool PayFine(int fineID)
        {
            bool isPaid = false;

            using (SqlConnection connection = clsDataAccessSettings.GetConnection())
            using (SqlCommand command = new SqlCommand("SP_Fine_Pay", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@FineID", fineID);

                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    isPaid = rowsAffected > 0;
                }
                catch (SqlException ex)
                {
                    // e.g. "Fine not found or already settled."
                    Console.WriteLine("PayFine error: " + ex.Message);
                }
            }

            return isPaid;
        }

        // =====================================================================
        // UPDATE — waive
        // =====================================================================

        /// <summary>
        /// Calls SP_Fine_Waive. Marks a pending fine as waived by a librarian/admin,
        /// with an optional reason for the audit trail.
        /// </summary>
        public static bool WaiveFine(int fineID, int waivedByUserID, string? waivedReason = null)
        {
            bool isWaived = false;

            using (SqlConnection connection = clsDataAccessSettings.GetConnection())
            using (SqlCommand command = new SqlCommand("SP_Fine_Waive", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@FineID", fineID);
                command.Parameters.AddWithValue("@WaivedBy", waivedByUserID);
                command.Parameters.AddWithValue("@WaivedReason", (object?)waivedReason ?? DBNull.Value);

                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    isWaived = rowsAffected > 0;
                }
                catch (SqlException ex)
                {
                    Console.WriteLine("WaiveFine error: " + ex.Message);
                }
            }

            return isWaived;
        }
    }
}
