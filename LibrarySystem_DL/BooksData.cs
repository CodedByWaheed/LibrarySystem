using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace LibrarySystem_DL
{
    public enum enCopyStatus { Available = 1, Borrowed = 2, Reserved = 3, Damaged = 4, Lost = 5 }

    public class BookDTO
    {
        public BookDTO() { }

        public BookDTO(int? bookID, int? categoryID, string? title, string? author,
            string? isbn, string? publisher, short? publishYear, string? edition,
            string? language, int? pageCount, string? coverImageUrl,
            bool? isReferenceOnly, bool? isArchived, DateTime? createdAt, DateTime? updatedAt)
        {
            BookID = bookID;
            CategoryID = categoryID;
            Title = title;
            Author = author;
            ISBN = isbn;
            Publisher = publisher;
            PublishYear = publishYear;
            Edition = edition;
            Language = language;
            PageCount = pageCount;
            CoverImageUrl = coverImageUrl;
            IsReferenceOnly = isReferenceOnly;
            IsArchived = isArchived;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
        }

        public int? BookID { get; set; }
        public int? CategoryID { get; set; }
        public string? Title { get; set; }
        public string? Author { get; set; }
        public string? ISBN { get; set; }
        public string? Publisher { get; set; }
        public short? PublishYear { get; set; }
        public string? Edition { get; set; }
        public string? Language { get; set; }
        public int? PageCount { get; set; }
        public string? CoverImageUrl { get; set; }
        public bool? IsReferenceOnly { get; set; }
        public bool? IsArchived { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        // Read-only — populated by SP_Book_GetByID / SP_Book_Search / vBookAvailability
        public string? CategoryName { get; set; }
        public int? TotalCopies { get; set; }
        public int? AvailableCopies { get; set; }
    }

    public class BookCopyDTO
    {
        public BookCopyDTO() { }

        public BookCopyDTO(int? copyID, int? bookID, string? barcode,
            string? shelfLocation, enCopyStatus? status, DateTime? acquiredAt, decimal? price)
        {
            CopyID = copyID;
            BookID = bookID;
            Barcode = barcode;
            ShelfLocation = shelfLocation;
            Status = status;
            AcquiredAt = acquiredAt;
            Price = price;
        }

        public int? CopyID { get; set; }
        public int? BookID { get; set; }
        public string? Barcode { get; set; }
        public string? ShelfLocation { get; set; }
        public enCopyStatus? Status { get; set; }
        public DateTime? AcquiredAt { get; set; }
        public decimal? Price { get; set; }
    }

    public class BooksData
    {
        // =====================================================================
        // Private helpers
        // =====================================================================

        private static BookDTO _MapReaderToBook(SqlDataReader reader)
        {
            var book = new BookDTO
            {
                BookID = reader["BookID"] as int?,
                Title = reader["Title"] as string,
                Author = reader["Author"] as string,
                ISBN = reader["ISBN"] as string,
            };

            if (_HasColumn(reader, "CategoryID") && reader["CategoryID"] != DBNull.Value)
                book.CategoryID = Convert.ToInt32(reader["CategoryID"]);

            if (_HasColumn(reader, "Publisher"))
                book.Publisher = reader["Publisher"] as string;

            if (_HasColumn(reader, "PublishYear") && reader["PublishYear"] != DBNull.Value)
                book.PublishYear = Convert.ToInt16(reader["PublishYear"]);

            if (_HasColumn(reader, "Edition"))
                book.Edition = reader["Edition"] as string;

            if (_HasColumn(reader, "Language"))
                book.Language = reader["Language"] as string;

            if (_HasColumn(reader, "PageCount") && reader["PageCount"] != DBNull.Value)
                book.PageCount = Convert.ToInt32(reader["PageCount"]);

            if (_HasColumn(reader, "CoverImageUrl"))
                book.CoverImageUrl = reader["CoverImageUrl"] as string;

            if (_HasColumn(reader, "IsReferenceOnly"))
                book.IsReferenceOnly = reader["IsReferenceOnly"] as bool?;

            if (_HasColumn(reader, "IsArchived"))
                book.IsArchived = reader["IsArchived"] as bool?;

            if (_HasColumn(reader, "CreatedAt"))
                book.CreatedAt = reader["CreatedAt"] as DateTime?;

            if (_HasColumn(reader, "UpdatedAt"))
                book.UpdatedAt = reader["UpdatedAt"] as DateTime?;

            // Joined / aggregated columns — present on SP_Book_GetByID, SP_Book_Search
            if (_HasColumn(reader, "CategoryName"))
                book.CategoryName = reader["CategoryName"] as string;

            if (_HasColumn(reader, "TotalCopies") && reader["TotalCopies"] != DBNull.Value)
                book.TotalCopies = Convert.ToInt32(reader["TotalCopies"]);

            if (_HasColumn(reader, "AvailableCopies") && reader["AvailableCopies"] != DBNull.Value)
                book.AvailableCopies = Convert.ToInt32(reader["AvailableCopies"]);

            return book;
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
        // CREATE
        // =====================================================================

        /// <summary>
        /// Calls SP_Book_Create. Also auto-creates the requested number of BookCopies rows.
        /// Returns the new BookID, or null on failure.
        /// </summary>
        public static int? AddNewBook(BookDTO book, int initialCopies = 1, string? shelfLocation = null)
        {
            int? newBookID = null;

            using (SqlConnection connection = clsDataAccessSettings.GetConnection())
            using (SqlCommand command = new SqlCommand("SP_Book_Create", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@CategoryID", (object?)book.CategoryID ?? DBNull.Value);
                command.Parameters.AddWithValue("@Title", book.Title ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@Author", book.Author ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@ISBN", book.ISBN ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@Publisher", (object?)book.Publisher ?? DBNull.Value);
                command.Parameters.AddWithValue("@PublishYear", (object?)book.PublishYear ?? DBNull.Value);
                command.Parameters.AddWithValue("@Edition", (object?)book.Edition ?? DBNull.Value);
                command.Parameters.AddWithValue("@Language", (object?)book.Language ?? "English");
                command.Parameters.AddWithValue("@PageCount", (object?)book.PageCount ?? DBNull.Value);
                command.Parameters.AddWithValue("@IsReferenceOnly", book.IsReferenceOnly ?? false);
                command.Parameters.AddWithValue("@InitialCopies", initialCopies);
                command.Parameters.AddWithValue("@ShelfLocation", (object?)shelfLocation ?? DBNull.Value);

                SqlParameter outputIdParam = new SqlParameter("@NewBookID", SqlDbType.Int)
                {
                    Direction = ParameterDirection.Output
                };
                command.Parameters.Add(outputIdParam);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();

                    if (outputIdParam.Value != DBNull.Value)
                        newBookID = (int)outputIdParam.Value;
                }
                catch (SqlException ex)
                {
                    // TODO: log ex — SP wraps insert+copies in a transaction with ROLLBACK on failure
                    Console.WriteLine("AddNewBook error: " + ex.Message);
                }
            }

            return newBookID;
        }

        // =====================================================================
        // READ
        // =====================================================================

        /// <summary>
        /// Calls SP_Book_GetByID. Returns null if not found or archived.
        /// </summary>
        public static BookDTO? GetBookById(int bookID)
        {
            BookDTO? book = null;

            using (SqlConnection connection = clsDataAccessSettings.GetConnection())
            using (SqlCommand command = new SqlCommand("SP_Book_GetByID", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@BookID", bookID);

                try
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            book = _MapReaderToBook(reader);
                        }
                    }
                }
                catch (SqlException ex)
                {
                    Console.WriteLine("GetBookById error: " + ex.Message);
                }
            }

            return book;
        }

        /// <summary>
        /// Calls SP_Book_Search. All parameters are optional — pass null/false to skip a filter.
        /// </summary>
        public static List<BookDTO> SearchBooks(string? keyword = null, int? categoryID = null, bool availableOnly = false)
        {
            List<BookDTO> books = new List<BookDTO>();

            using (SqlConnection connection = clsDataAccessSettings.GetConnection())
            using (SqlCommand command = new SqlCommand("SP_Book_Search", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@keyword", (object?)keyword ?? DBNull.Value);
                command.Parameters.AddWithValue("@CategoryID", (object?)categoryID ?? DBNull.Value);
                command.Parameters.AddWithValue("@AvailableOnly", availableOnly);

                try
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            books.Add(_MapReaderToBook(reader));
                        }
                    }
                }
                catch (SqlException ex)
                {
                    Console.WriteLine("SearchBooks error: " + ex.Message);
                }
            }

            return books;
        }

        // =====================================================================
        // UPDATE
        // =====================================================================

        /// <summary>
        /// Calls SP_Book_Update. Only non-null fields are applied (ISNULL pattern server-side).
        /// NOTE: the SP has no OUTPUT/RETURN status — this only reports whether the call
        /// completed without throwing, not whether a row actually matched. Add @@ROWCOUNT
        /// output to the SP if you need a true affected-rows signal.
        /// </summary>
        public static bool UpdateBook(BookDTO book)
        {
            if (book.BookID == null)
                return false;

            bool isUpdated = false;

            using (SqlConnection connection = clsDataAccessSettings.GetConnection())
            using (SqlCommand command = new SqlCommand("SP_Book_Update", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@BookID", book.BookID);
                command.Parameters.AddWithValue("@Title", (object?)book.Title ?? DBNull.Value);
                command.Parameters.AddWithValue("@Author", (object?)book.Author ?? DBNull.Value);
                command.Parameters.AddWithValue("@Publisher", (object?)book.Publisher ?? DBNull.Value);
                command.Parameters.AddWithValue("@PublishYear", (object?)book.PublishYear ?? DBNull.Value);
                command.Parameters.AddWithValue("@CategoryID", (object?)book.CategoryID ?? DBNull.Value);
                command.Parameters.AddWithValue("@IsReferenceOnly", (object?)book.IsReferenceOnly ?? DBNull.Value);

                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    isUpdated = rowsAffected > 0;
                }
                catch (SqlException ex)
                {
                    Console.WriteLine("UpdateBook error: " + ex.Message);
                }
            }

            return isUpdated;
        }

        // =====================================================================
        // DELETE (soft delete / archive)
        // =====================================================================

        /// <summary>
        /// Calls SP_Book_Delete. return 1 if successfl.
        /// NOTE: the SP currently only has an explicit RETURN -1 on the blocked path;
        /// the success path falls through with the implicit default RETURN 0. This method
        /// treats "0 with no exception" as success, but the SP should be patched to
        /// `RETURN 1` after the UPDATE for an unambiguous signal.
        /// </summary>
        public static bool DeleteBook(int bookID)
        {
            bool isDeleted = false;

            using (SqlConnection connection = clsDataAccessSettings.GetConnection())
            using (SqlCommand command = new SqlCommand("SP_Book_Delete", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@BookID", bookID);

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
                    isDeleted = code >= 0;  // -1 = blocked by active loans; 0/1 = success (see note above)
                }
                catch (SqlException ex)
                {
                    Console.WriteLine("DeleteBook error: " + ex.Message);
                }
            }

            return isDeleted;
        }
    }
}
