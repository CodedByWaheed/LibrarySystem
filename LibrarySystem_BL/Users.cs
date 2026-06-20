
using LibrarySystem_DL;

namespace LibrarySystem_BL
{
    public class Users
    {
        public enum enMode { Add = 1, Update = 2 }
        private enMode _Mode;

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
            UserID = -1;
            RoleID = null;
            MembershipNumber = "";
            FullName = "";
            NationaleID = "";
            Email = "";
            Phone = "";
            PasswordHash = "";
            ProfileImageUrl = "";
            MemebershipStatus = null;   // 0 is not a valid enMembershipStatus member — leave unset
            MemebershipType = null;     // same for enMembershipType
            MaxBookBorrow = 0;
            JoinedAt = DateTime.MinValue;
            MemberShipExpiray = DateTime.MinValue;
            CreatedAt = DateTime.MinValue;
            UpdatedAt = DateTime.MinValue;
            _Mode = enMode.Add;
        }

        public Users(UserDTO userDTO, enMode mode = enMode.Update)
        {
            UserID = userDTO.UserID;
            RoleID = userDTO.RoleID;
            MembershipNumber = userDTO.MembershipNumber;
            FullName = userDTO.FullName;
            NationaleID = userDTO.NationalID;
            Email = userDTO.Email;
            Phone = userDTO.Phone;
            PasswordHash = userDTO.PasswordHash;
            ProfileImageUrl = userDTO.ProfileImageUrl;
            MemebershipStatus = userDTO.MembershipStatus;
            MemebershipType = userDTO.MembershipType;
            MaxBookBorrow = userDTO.MaxBookBorrow;
            JoinedAt = userDTO.JoinedAt;
            MemberShipExpiray = userDTO.MembershipExpiry;
            CreatedAt = userDTO.CreatedAt;
            UpdatedAt = userDTO.UpdatedAt;
            _Mode = mode;   
        }

        private UserDTO _MapToDTO()
        {
            return new UserDTO
            {
                UserID = this.UserID,
                RoleID = this.RoleID,
                MembershipNumber = this.MembershipNumber,
                FullName = this.FullName,
                NationalID = this.NationaleID,
                Email = this.Email,
                Phone = this.Phone,
                PasswordHash = this.PasswordHash,
                ProfileImageUrl = this.ProfileImageUrl,
                MembershipStatus = this.MemebershipStatus,
                MembershipType = this.MemebershipType,
                MaxBookBorrow = this.MaxBookBorrow,
                JoinedAt = this.JoinedAt,
                MembershipExpiry = this.MemberShipExpiray,
                CreatedAt = this.CreatedAt,
                UpdatedAt = this.UpdatedAt
            };
        }
      

        private bool _AddNewUser()
        {
            UserDTO userDTO = _MapToDTO();
            this.UserID = UsersData.AddNewUser(userDTO);
            return UserID > 0;
        }

        private bool _UpdateUser()
        {
            UserDTO userDTO = _MapToDTO();
            return UsersData.UpdateUser(userDTO);
        }

        private bool _AddNewUserAfterSaveModeChange()
        {
            bool result = _AddNewUser();
            if (result)
                _Mode = enMode.Update;

            return result;
        }

        public bool Save()
        {
            return _Mode switch
            {
                enMode.Add => _AddNewUserAfterSaveModeChange(),
                enMode.Update => _UpdateUser(),
                _ => throw new InvalidOperationException("Invalid mode")
            };
        }

        /// <summary>
        /// Loads a user by ID from the database. Returns null if not found.
        /// The returned object is in Update mode — calling Save() will update, not insert.
        /// </summary>
        public static Users? Find(int userID)
        {
            UserDTO? dto = UsersData.GetUserById(userID);
            return dto == null ? null : new Users(dto, enMode.Update);
        }

        /// <summary>
        /// Loads all users, optionally filtered by membership status.
        /// </summary>
        public static List<Users> GetAll(enMembershipStatus? status = null)
        {
            List<UserDTO> dtos = UsersData.GetAllUsers(status);
            List<Users> result = new List<Users>();

            foreach (UserDTO dto in dtos)
                result.Add(new Users(dto, enMode.Update));

            return result;
        }

        /// <summary>
        /// Deletes this user from the database. Fails (returns false) if the user
        /// has active loans — the DL layer surfaces that as a failed delete, not an exception.
        /// </summary>
        public bool Delete()
        {
            if (UserID == null || UserID <= 0)
                return false;

            bool isDeleted = UsersData.DeleteUser(UserID.Value);
            return isDeleted;
        }

        /// <summary>
        /// Static convenience overload — delete by ID without loading the full object first.
        /// </summary>
        public static bool Delete(int userID)
        {
            return UsersData.DeleteUser(userID);
        }
    }
}
