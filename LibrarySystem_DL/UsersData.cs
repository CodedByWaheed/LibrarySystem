
using Microsoft.Data.SqlClient;
using System.Data;

namespace LibrarySystem_DL
{
    public enum enMembershipStatus { Active = 1, Susbend = 2, Expired = 3 }
    public enum enMembershipType { Regular = 1, Premium = 2, Staff =3 }
    public enum enRoleName { Admin = 1 , Librarian = 2 , User = 3 }


    public class UserDTO
    {
        public UserDTO(int? userID, int? roleID, string? membershipNumber,
            string? fullName, string? nationalID, string? email, string? phone,
            string? passwordHash, string? profileImageUrl, enMembershipStatus? membershipStatus,
            enMembershipType? membershipType, short? maxBookBorrow, DateTime? joinedAt,
            DateTime? membershipExpiry, DateTime? createdAt, DateTime? updatedAt)
        {
            UserID = userID;
            RoleID = roleID;
            MembershipNumber = membershipNumber;
            FullName = fullName;
            NationalID = nationalID;
            Email = email;
            Phone = phone;
            PasswordHash = passwordHash;
            ProfileImageUrl = profileImageUrl;
            MembershipStatus = membershipStatus;
            MembershipType = membershipType;
            MaxBookBorrow = maxBookBorrow;
            JoinedAt = joinedAt;
            MembershipExpiry = membershipExpiry;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
        }

        public UserDTO() { }

        public int? UserID { get; set; }
        public int? RoleID { get; set; }
        public string? MembershipNumber { get; set; }
        public string? FullName { get; set; }
        public string? NationalID { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public string? PasswordHash { get; set; }
        public string? ProfileImageUrl { get; set; }
        public enMembershipStatus? MembershipStatus { get; set; }
        public enMembershipType? MembershipType { get; set; }
        public short? MaxBookBorrow { get; set; }
        public DateTime? JoinedAt { get; set; }
        public DateTime? MembershipExpiry { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }

    public class UsersData
    {



        // =====================================================================
        // Private helpers — mapping between DB and C# types
        // =====================================================================

        private static UserDTO _MapReaderToUser(SqlDataReader reader)
        {
            var user = new UserDTO
            {
                UserID = reader["UserID"] as int?,
                MembershipNumber = reader["MembershipNumber"] as string,
                FullName = reader["FullName"] as string,
                Email = reader["Email"] as string,
            };

            // Optional columns — guard with HasColumn in case different SPs return different shapes
            if (_HasColumn(reader, "phone"))
                user.Phone = reader["phone"] as string;

            if (_HasColumn(reader, "MembershipStatus"))
                user.MembershipStatus = reader["MembershipStatus"] as enMembershipStatus?;

            if (_HasColumn(reader, "MembershipType"))
                user.MembershipType = reader["MembershipType"] as enMembershipType?;

            if (_HasColumn(reader, "MaxBorrowLimit"))
                user.MaxBookBorrow = reader["MaxBorrowLimit"] as short?;

            if (_HasColumn(reader, "JoinedAt"))
                user.JoinedAt = reader["JoinedAt"] as DateTime?;

            if (_HasColumn(reader, "MembershipExpiry"))
                user.MembershipExpiry = reader["MembershipExpiry"] as DateTime?;

            if (_HasColumn(reader, "RoleID"))
            {
                user.RoleID = reader["RoleID"] as int?;
            }

            return user;
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

        //private static string _StatusToString(enMembershipStatus status)
        //{
        //    return status switch
        //    {
        //        enMembershipStatus.Active => "active",
        //        enMembershipStatus.Susbend => "suspended",
        //        enMembershipStatus.Expired => "expired",
        //        // NOTE: the SQL Server schema's CHECK constraint only allows
        //        // 'active' | 'suspended' | 'expired'. 'Cancelled' has no DB equivalent yet —
        //        // either add it to the CHECK constraint or treat it as 'expired' in the app.
        //        enMembershipStatus.Cancelled => "expired",
        //        _ => "active"
        //    };
        //}

        //private static enMembershipStatus? _StringToStatus(string? status)
        //{
        //    return status?.ToLower() switch
        //    {
        //        "active" => enMembershipStatus.Active,
        //        "suspended" => enMembershipStatus.Susbend,
        //        "expired" => enMembershipStatus.Expired,
        //        _ => null
        //    };
        //}

        //private static string _MembershipTypeToString(enMembershipType type)
        //{
        //    return type switch
        //    {
        //        enMembershipType.Regular => "regular",
        //        enMembershipType.Premium => "premium",
        //        // NOTE: the SQL Server schema's CHECK constraint only allows
        //        // 'regular' | 'premium' | 'staff'. 'Student' has no DB equivalent yet —
        //        // either add it to the CHECK constraint or map it to 'regular'.
        //        enMembershipType.Student => "regular",
        //        enMembershipType.Staff => "staff",
        //        _ => "regular"
        //    };
        //}

        //private static enMembershipType? _StringToMembershipType(string? type)
        //{
        //    return type?.ToLower() switch
        //    {
        //        "regular" => enMembershipType.Regular,
        //        "premium" => enMembershipType.Premium,
        //        "staff" => enMembershipType.Staff,
        //        _ => null
        //    };
        //}

        //private static string? _RoleNameToString(enRoleName Name)
        //{
        //    return Name switch
        //    {
        //        enRoleName.Admin => "admin",
        //        enRoleName.Librarian => "librarian",
        //        enRoleName.User => "user",
        //        _ => null
        //    };

        //}

        //private static enRoleName? _StringToRoleName(string? Name)
        //{
        //    return Name?.ToLower() switch
        //    {
        //        "admin" => enRoleName.Admin,
        //        "librarian" => enRoleName.Librarian,
        //        "user" => enRoleName.User,
        //        _ => null
        //    };
        //}


        // =====================================================================
        // End Of Private helpers
        // =====================================================================


        /// <summary>
        /// Calls sp_User_Create. Returns the new UserID, or null on failure.
        /// </summary>
        public static int? AddNewUser(UserDTO user)
        {
            int? newUserID = null;

            using (SqlConnection connection = clsDataAccessSettings.GetConnection())
            using (SqlCommand command = new SqlCommand("sp_User_Create", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@RoleID", user.RoleID.HasValue? user.RoleID : (int)enRoleName.User);
                command.Parameters.AddWithValue("@FullName", user.FullName ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@NationalID", (object?)user.NationalID ?? DBNull.Value);
                command.Parameters.AddWithValue("@email", user.Email ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@phone", (object?)user.Phone ?? DBNull.Value);
                command.Parameters.AddWithValue("@passwordHash", user.PasswordHash ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@membershipType",
                    user.MembershipType.HasValue ? user.MembershipType.Value: (int)enMembershipType.Regular);
                command.Parameters.AddWithValue("@joined_at", user.JoinedAt ?? (object)DateTime.Now);
                command.Parameters.AddWithValue("@membership_expiry", (object?)user.MembershipExpiry ?? DBNull.Value);

                SqlParameter outputIdParam = new SqlParameter("@new_user_id", SqlDbType.Int)
                {
                    Direction = ParameterDirection.Output
                };
                command.Parameters.Add(outputIdParam);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();

                    if (outputIdParam.Value != DBNull.Value)
                        newUserID = (int)outputIdParam.Value;
                }
                catch (SqlException ex)
                {
                    // TODO: log ex
                    Console.WriteLine("AddNewUser error: " + ex.Message);
                }
            }

            return newUserID;
        }


        /// <summary>
        /// Calls sp_User_GetById. Returns null if not found.
        /// </summary>
        public static UserDTO? GetUserById(int userID)
        {
            UserDTO? user = null;

            using (SqlConnection connection = clsDataAccessSettings.GetConnection())
            using (SqlCommand command = new SqlCommand("SP_User_GetByID", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@UserID", userID);

                try
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            user = _MapReaderToUser(reader);
                        }
                    }
                }
                catch (SqlException ex)
                {
                    //TODO : add log here
                    Console.WriteLine("GetUserById error: " + ex.Message);
                }
            }

            return user;
        }

        /// <summary>
        /// Calls sp_User_GetAll. Pass null status to get all users regardless of status.
        /// </summary>
        public static List<UserDTO> GetAllUsers(enMembershipStatus? status = null)
        {
            List<UserDTO> users = new List<UserDTO>();

            using (SqlConnection connection = clsDataAccessSettings.GetConnection())
            using (SqlCommand command = new SqlCommand("sp_User_GetAll", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@status",
                    status.HasValue ? (int)status.Value : DBNull.Value);

                try
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            users.Add(_MapReaderToUser(reader));
                        }
                    }
                }
                catch (SqlException ex)
                {
                    Console.WriteLine("GetAllUsers error: " + ex.Message);
                }
            }

            return users;
        }

        /// <summary>
        /// Calls sp_User_Update. Only non-null fields on the DTO are updated (COALESCE pattern server-side).
        /// Returns true if a row was affected.
        /// </summary>
        public static bool UpdateUser(UserDTO user)
        {
            if (user.UserID == null) 
                return false;

            bool isUpdated = false;

            using (SqlConnection connection = clsDataAccessSettings.GetConnection())
            using (SqlCommand command = new SqlCommand("sp_User_Update", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@UserID", user.UserID);
                command.Parameters.AddWithValue("@FullName", (object?)user.FullName ?? DBNull.Value);
                command.Parameters.AddWithValue("@phone", (object?)user.Phone ?? DBNull.Value);
                command.Parameters.AddWithValue("@membershipStatus",
                    user.MembershipStatus.HasValue ? (int)user.MembershipStatus.Value : DBNull.Value);
                command.Parameters.AddWithValue("@membershipExpiry", (object?)user.MembershipExpiry ?? DBNull.Value);
                command.Parameters.AddWithValue("@RoleID", (object?)user.RoleID ?? DBNull.Value);
                var ReturnStatus = new SqlParameter("@StatusCode", SqlDbType.Int)
                {
                    Direction = ParameterDirection.Output
                };
                command.Parameters.Add(ReturnStatus);

                try
                {
                    connection.Open();
                     command.ExecuteNonQuery();
                    isUpdated = (int)ReturnStatus.Value > 0;
                }
                catch (SqlException ex)
                {
                    Console.WriteLine("UpdateUser error: " + ex.Message);
                }
            }

            return isUpdated;
        }


        /// <summary>
        /// Calls sp_User_Delete. Throws a friendly message if the user has active loans
        /// (the SP raises an error in that case).
        /// </summary>
        public static bool DeleteUser(int userID)
        {
            bool isDeleted = false;

            using (SqlConnection connection = clsDataAccessSettings.GetConnection())
            using (SqlCommand command = new SqlCommand("sp_User_Delete", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@UserID", userID);
                var ReturnValue = new SqlParameter(null ,SqlDbType.Int)
                {
                    Direction = ParameterDirection.ReturnValue
                };
                command.Parameters.Add(ReturnValue);

                try
                {
                    connection.Open();
                     command.ExecuteNonQuery();
                    isDeleted = (int)ReturnValue.Value > 0;
                }
                catch (SqlException ex)
                {
                    // e.g. "Cannot delete user with active loans."
                    Console.WriteLine("DeleteUser error: " + ex.Message);
                }
            }

            return isDeleted;
        }

    }
}

