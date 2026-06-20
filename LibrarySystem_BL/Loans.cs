using LibrarySystem_DL;

namespace LibrarySystem_BL
{
    /// <summary>
    /// Unlike Users/Books, a loan's lifecycle isn't a simple Add/Update — it moves through
    /// distinct operations (Issue → [Extend]* → Return), each with its own business rules
    /// enforced server-side (active membership, copy availability, borrow limits, unpaid fines,
    /// reservation conflicts). So this class exposes Issue()/Return()/Extend() instead of Save().
    /// </summary>
    public class Loans
    {
        public int? LoanID { get; private set; }
        public int? UserID { get; set; }
        public int? CopyID { get; set; }
        public DateTime? LoanDate { get; private set; }
        public DateTime? DueDate { get; private set; }
        public DateTime? ReturnDate { get; private set; }
        public byte? ExtensionsCount { get; private set; }
        public byte? MaxExtensions { get; private set; }
        public enLoanStatus? Status { get; private set; }
        public DateTime? CreatedAt { get; private set; }

        // Read-only — populated when loaded via Find() (joined data)
        public string? FullName { get; private set; }
        public string? Email { get; private set; }
        public string? Title { get; private set; }
        public string? ISBN { get; private set; }
        public string? Barcode { get; private set; }
        public string? ShelfLocation { get; private set; }
        public int? DaysOverdue { get; private set; }

        /// <summary>
        /// The most recent error message from Issue()/Return()/Extend(), if the last
        /// call returned false. Surfaces the SP's RAISERROR text directly, e.g.
        /// "User has reached the maximum borrow limit."
        /// </summary>
        public string? LastError { get; private set; }

        public Loans() { }

        private Loans(LoanDTO loanDTO)
        {
            LoanID = loanDTO.LoanID;
            UserID = loanDTO.UserID;
            CopyID = loanDTO.CopyID;
            LoanDate = loanDTO.LoanDate;
            DueDate = loanDTO.DueDate;
            ReturnDate = loanDTO.ReturnDate;
            ExtensionsCount = loanDTO.ExtensionsCount;
            MaxExtensions = loanDTO.MaxExtensions;
            Status = loanDTO.Status;
            CreatedAt = loanDTO.CreatedAt;

            FullName = loanDTO.FullName;
            Email = loanDTO.Email;
            Title = loanDTO.Title;
            ISBN = loanDTO.ISBN;
            Barcode = loanDTO.Barcode;
            ShelfLocation = loanDTO.ShelfLocation;
            DaysOverdue = loanDTO.DaysOverdue;
        }

        /// <summary>
        /// Issues a new loan for the given user/copy. On success, populates LoanID and
        /// reloads the full record via Find(). On failure, LastError holds the reason.
        /// </summary>
        public static Loans? Issue(int userID, int copyID, int loanDays = 14)
        {
            int? newLoanID = LoansData.IssueLoan(userID, copyID, out string? error, loanDays);

            if (newLoanID == null)
            {
                return new Loans { LastError = error };
            }

            Loans? loan = Find(newLoanID.Value);
            return loan;
        }

        /// <summary>
        /// Returns this loan. Triggers server-side fine calculation if overdue.
        /// Returns false (with LastError set) if the loan was already closed.
        /// </summary>
        public bool Return()
        {
            if (LoanID == null || LoanID <= 0)
            {
                LastError = "Loan is not loaded — call Find() first.";
                return false;
            }

            bool success = LoansData.ReturnLoan(LoanID.Value, out string? error);
            LastError = error;

            if (success)
            {
                // Refresh local state from DB so Status/ReturnDate reflect the trigger's work
                Loans? refreshed = Find(LoanID.Value);
                if (refreshed != null)
                {
                    ReturnDate = refreshed.ReturnDate;
                    Status = refreshed.Status;
                }
            }

            return success;
        }

        public static bool Return(int loanID)
        {
            return LoansData.ReturnLoan(loanID, out _);
        }

        /// <summary>
        /// Extends the due date. Fails if max extensions reached, the loan isn't
        /// active/extended, or another member is waiting on a reservation for this book.
        /// </summary>
        public bool Extend(int extendDays = 7)
        {
            if (LoanID == null || LoanID <= 0)
            {
                LastError = "Loan is not loaded — call Find() first.";
                return false;
            }

            bool success = LoansData.ExtendLoan(LoanID.Value, out string? error, extendDays);
            LastError = error;

            if (success)
            {
                Loans? refreshed = Find(LoanID.Value);
                if (refreshed != null)
                {
                    DueDate = refreshed.DueDate;
                    ExtensionsCount = refreshed.ExtensionsCount;
                    Status = refreshed.Status;
                }
            }

            return success;
        }

        /// <summary>
        /// Loads a loan by ID, including joined member/book/copy details. Returns null if not found.
        /// </summary>
        public static Loans? Find(int loanID)
        {
            LoanDTO? dto = LoansData.GetLoanById(loanID);
            return dto == null ? null : new Loans(dto);
        }
    }
}
