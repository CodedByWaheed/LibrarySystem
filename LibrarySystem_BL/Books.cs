using LibrarySystem_DL;

namespace LibrarySystem_BL
{
    public class Books
    {
        public enum enMode { Add = 1, Update = 2 }
        private enMode _Mode;

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

        // Used only on Add — not stored on the Books table itself, consumed by SP_Book_Create
        public int InitialCopies { get; set; } = 1;
        public string? ShelfLocation { get; set; }

        // Read-only — populated when loaded via Find()/Search() (joined/aggregated data)
        public string? CategoryName { get; private set; }
        public int? TotalCopies { get; private set; }
        public int? AvailableCopies { get; private set; }

        public Books()
        {
            BookID = -1;
            CategoryID = null;
            Title = "";
            Author = "";
            ISBN = "";
            Publisher = "";
            PublishYear = null;
            Edition = "";
            Language = "English";
            PageCount = null;
            CoverImageUrl = "";
            IsReferenceOnly = false;
            IsArchived = false;
            CreatedAt = DateTime.MinValue;
            UpdatedAt = DateTime.MinValue;
            _Mode = enMode.Add;
        }

        public Books(BookDTO bookDTO, enMode mode = enMode.Update)
        {
            BookID = bookDTO.BookID;
            CategoryID = bookDTO.CategoryID;
            Title = bookDTO.Title;
            Author = bookDTO.Author;
            ISBN = bookDTO.ISBN;
            Publisher = bookDTO.Publisher;
            PublishYear = bookDTO.PublishYear;
            Edition = bookDTO.Edition;
            Language = bookDTO.Language;
            PageCount = bookDTO.PageCount;
            CoverImageUrl = bookDTO.CoverImageUrl;
            IsReferenceOnly = bookDTO.IsReferenceOnly;
            IsArchived = bookDTO.IsArchived;
            CreatedAt = bookDTO.CreatedAt;
            UpdatedAt = bookDTO.UpdatedAt;

            CategoryName = bookDTO.CategoryName;
            TotalCopies = bookDTO.TotalCopies;
            AvailableCopies = bookDTO.AvailableCopies;

            _Mode = mode;
        }

        private BookDTO _MapToDTO()
        {
            return new BookDTO
            {
                BookID = BookID,
                CategoryID = CategoryID,
                Title = Title,
                Author = Author,
                ISBN = ISBN,
                Publisher = Publisher,
                PublishYear = PublishYear,
                Edition = Edition,
                Language = Language,
                PageCount = PageCount,
                CoverImageUrl = CoverImageUrl,
                IsReferenceOnly = IsReferenceOnly,
                IsArchived = IsArchived,
                CreatedAt = CreatedAt,
                UpdatedAt = UpdatedAt
            };
        }

        private bool _AddNewBook()
        {
            BookDTO bookDTO = _MapToDTO();
            this.BookID = BooksData.AddNewBook(bookDTO, InitialCopies, ShelfLocation);
            return BookID > 0;
        }

        private bool _UpdateBook()
        {
            BookDTO bookDTO = _MapToDTO();
            return BooksData.UpdateBook(bookDTO);
        }

        private bool _AddNewBookAfterSaveModeChange()
        {
            bool result = _AddNewBook();
            if (result)
                _Mode = enMode.Update;

            return result;
        }

        public bool Save()
        {
            return _Mode switch
            {
                enMode.Add => _AddNewBookAfterSaveModeChange(),
                enMode.Update => _UpdateBook(),
                _ => throw new InvalidOperationException("Invalid mode")
            };
        }

        /// <summary>
        /// Loads a book by ID (with availability counts). Returns null if not found or archived.
        /// </summary>
        public static Books? Find(int bookID)
        {
            BookDTO? dto = BooksData.GetBookById(bookID);
            return dto == null ? null : new Books(dto, enMode.Update);
        }

        /// <summary>
        /// Searches books by keyword / category / availability. All filters optional.
        /// </summary>
        public static List<Books> Search(string? keyword = null, int? categoryID = null, bool availableOnly = false)
        {
            List<BookDTO> dtos = BooksData.SearchBooks(keyword, categoryID, availableOnly);
            List<Books> result = new List<Books>();

            foreach (BookDTO dto in dtos)
                result.Add(new Books(dto, enMode.Update));

            return result;
        }

        /// <summary>
        /// Archives (soft-deletes) this book. Fails if any copy has an active loan.
        /// </summary>
        public bool Delete()
        {
            if (BookID == null || BookID <= 0)
                return false;

            return BooksData.DeleteBook(BookID.Value);
        }

        public static bool Delete(int bookID)
        {
            return BooksData.DeleteBook(bookID);
        }
    }
}
