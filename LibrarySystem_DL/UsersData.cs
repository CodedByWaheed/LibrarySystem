
using Microsoft.Data.SqlClient;

namespace LibrarySystem_DL
{
    public enum enMembershipStatus { Active = 1, Susbend = 2, Expired = 3, Cancelled = 4 }
    public enum enMembershipType { Regular = 1 , Student = 2 , Premium =3 , Staff = 4 }

    public class UserModelDTO
    {
        public class UserDTO
        {

            public UserDTO(int? UserID , int? RoleID , string? MebershipNumber , 
                string? FullName , string? NationalnID, string?Email , string?Phone , 
                string?PasswordHash , string?ProfileImageUrl , enMembershipStatus? MembershipStatus ,
                enMembershipType? MembershipType , short? MaxBookBorrow ,DateTime? JoinedAt ,
                DateTime? MeberShipExpiray , DateTime?CreatedAt , DateTime?UpdatedAt)
            {
                this.UserID = UserID?? null;
                this.RoleID = RoleID ?? null;
                this.MembershipNumber = MembershipNumber ?? null;
                this.FullName = FullName ?? null;
                this.NationaleID = NationaleID ?? null;
                this.Email = Email ?? null;
                this.Phone = Phone ?? null;
                this.PasswordHash = PasswordHash ?? null;
                this.ProfileImageUrl = ProfileImageUrl ?? null;
                this.MemebershipStatus = MemebershipStatus ?? null;
                this.MemebershipType = MemebershipType ?? null;
                this.MaxBookBorrow = MaxBookBorrow ?? null;
                this.JoinedAt = JoinedAt ?? null;
                this.MemberShipExpiray = MemberShipExpiray ?? null;
                this.CreatedAt = CreatedAt ?? null;
                this.UpdatedAt = UpdatedAt ?? null;
               
            }
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

        }
    }
    public class UsersData
    {
        




    }
}

