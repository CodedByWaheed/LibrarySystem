using LibrarySystem_DL;

namespace LibrarySystem_BL
{
    public class Users
    {
        public enum enMode { Add = 1, Update = 2 }
        enMode _Mode;
        public int? UserID { get; set; }
        public int? RoleID { get; set; }
        public string? MembershipNumber { get; set; }
        public string? FullName { get; set; }
        public string? NationaleID { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public string? PasswordHash { get; set; }
        public string? ProfileImageUrl { get; set; }
        public enMembershipStatus? MemebershipStatus { get; set; }
        public enMembershipType? MemebershipType { get; set; }
        public short? MaxBookBorrow { get; set; }
        public DateTime? JoinedAt { get; set; }
        public DateTime? MemberShipExpiray { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public Users()
        {
            this.UserID = -1;
            this.RoleID = -1;
            this.MembershipNumber = "";
            this.FullName = "";
            this.NationaleID = "";
            this.Email = "";
            this.Phone = "";
            this.PasswordHash = "";
            this.ProfileImageUrl = "";
            this.MemebershipStatus = 0;
            this.MemebershipType = 0;
            this.MaxBookBorrow = 0;
            this.JoinedAt = DateTime.MinValue;
            this.MemberShipExpiray = DateTime.MinValue;
            this.CreatedAt  = DateTime.MinValue;
            this.UpdatedAt = DateTime.MinValue;
            _Mode = enMode.Add;
   
        }
        public Users(UserModelDTO.UserDTO UserDTO , enMode Mode = enMode .Update)
        {
            this.UserID = UserDTO.UserID;
            this.RoleID = UserDTO.RoleID;
            this.MembershipNumber = UserDTO.MembershipNumber;
            this.FullName = UserDTO.FullName;
            this.NationaleID = UserDTO.NationaleID;
            this.Email = UserDTO.Email;
            this.Phone = UserDTO.Phone;
            this.PasswordHash = UserDTO.PasswordHash;
            this.ProfileImageUrl = UserDTO.ProfileImageUrl;
            this.MemebershipStatus = UserDTO.MemebershipStatus;
            this.MemebershipType = UserDTO.MemebershipType;
            this.MaxBookBorrow = UserDTO.MaxBookBorrow;
            this.JoinedAt = UserDTO.JoinedAt;
            this.MemberShipExpiray = UserDTO.MemberShipExpiray;
            this.CreatedAt = UserDTO.CreatedAt;
            this.UpdatedAt = UserDTO.UpdatedAt;
            _Mode = enMode.Add;
        }

    }
}
