using LibrarySystem_DL;
using System.Linq;

namespace LibrarySystem_BL
{
    /// <summary>
    /// a fine moves through states (Pending → Paid / Waived) rather than a
    /// generic Add/Update — fines are only ever created server-side by the late-return
    /// trigger, never directly by the app. So this class exposes Pay()/Waive() instead of Save().
    /// </summary>
    public class Fines
    {
        public int? FineID { get; private set; }
        public int? LoanID { get; private set; }
        public int? UserID { get; private set; }
        public enFineType? FineType { get; private set; }
        public decimal? Amount { get; private set; }
        public enFineStatus? Status { get; private set; }
        public string? WaivedReason { get; private set; }
        public int? WaivedBy { get; private set; }
        public DateTime? IssuedAt { get; private set; }
        public DateTime? PaidAt { get; private set; }

        // Read-only — populated by GetByUser()
        public string? BookTitle { get; private set; }

        public Fines() { }

        private Fines(FineDTO fineDTO)
        {
            FineID = fineDTO.FineID;
            LoanID = fineDTO.LoanID;
            UserID = fineDTO.UserID;
            FineType = fineDTO.FineType;
            Amount = fineDTO.Amount;
            Status = fineDTO.Status;
            WaivedReason = fineDTO.WaivedReason;
            WaivedBy = fineDTO.WaivedBy;
            IssuedAt = fineDTO.IssuedAt;
            PaidAt = fineDTO.PaidAt;
            BookTitle = fineDTO.BookTitle;
        }

        /// <summary>
        /// Loads all fines (pending, paid, and waived) for a given member, newest first.
        /// </summary>
        public static List<Fines> GetByUser(int userID)
        {
            List<FineDTO> dtos = FinesData.GetFinesByUser(userID);
            List<Fines> result = new List<Fines>();

            foreach (FineDTO dto in dtos)
                result.Add(new Fines(dto));

            return result;
        }

        /// <summary>
        /// Convenience filter — only the still-unpaid fines for a member.
        /// Useful before SP_Loan_Issue, which blocks new loans while fines are pending.
        /// </summary>
        public static List<Fines> GetPendingByUser(int userID)
        {
            return GetByUser(userID).Where(f => f.Status == enFineStatus.Pending).ToList();
        }

        /// <summary>
        /// Marks this fine as paid. Returns false if it doesn't exist or was already settled.
        /// </summary>
        public bool Pay()
        {
            if (FineID == null || FineID <= 0)
                return false;

            bool success = FinesData.PayFine(FineID.Value);
            if (success)
                Status = enFineStatus.Paid;

            return success;
        }

        public static bool Pay(int fineID)
        {
            return FinesData.PayFine(fineID);
        }

        /// <summary>
        /// Waives this fine. waivedByUserID should be the librarian/admin performing
        /// the action, so it's recorded for the audit trail.
        /// </summary>
        public bool Waive(int waivedByUserID, string? reason = null)
        {
            if (FineID == null || FineID <= 0)
                return false;

            bool success = FinesData.WaiveFine(FineID.Value, waivedByUserID, reason);
            if (success)
            {
                Status = enFineStatus.Waived;
                WaivedBy = waivedByUserID;
                WaivedReason = reason;
            }

            return success;
        }

        public static bool Waive(int fineID, int waivedByUserID, string? reason = null)
        {
            return FinesData.WaiveFine(fineID, waivedByUserID, reason);
        }
    }
}
