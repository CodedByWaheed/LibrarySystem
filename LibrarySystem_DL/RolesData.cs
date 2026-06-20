using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace LibrarySystem_DL
{
    public class RoleDTO
    {
        public RoleDTO() { }

        public RoleDTO(int? roleID, string? roleName, string? description,
            int? permission, DateTime? createdAt)
        {
            RoleID = roleID;
            RoleName = roleName;
            Description = description;
            Permission = permission;
            CreatedAt = createdAt;
        }

        public int? RoleID { get; set; }
        public string? RoleName { get; set; }
        public string? Description { get; set; }
        public int? Permission { get; set; }
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks whether this role has a given permission bit set.
        /// Example: role.HasPermission(enPermission.BookDelete)
        /// </summary>
        public bool HasPermission(enPermission permission)
        {
            if (Permission == null) return false;
            return (Permission.Value & (int)permission) == (int)permission;
        }
    }

    [Flags]
    public enum enPermission { None = 0,UserCreate = 1,UserDelete = 2,UserUpdate = 4,BookCreate = 8,
        BookDelete = 16,BookUpdate = 32,LoanIssue = 64,LoanReturn = 128,Admin = 255 }

    public class RolesData
    {
        private static RoleDTO _MapReaderToRole(SqlDataReader reader)
        {
            return new RoleDTO
            {
                RoleID = reader["RoleID"] as int?,
                RoleName = reader["RoleName"] as string,
                Description = _HasColumn(reader, "Description") ? reader["Description"] as string : null,
                Permission = _HasColumn(reader, "Permission") && reader["Permission"] != DBNull.Value
                    ? Convert.ToInt32(reader["Permission"]) : (int?)null,
                CreatedAt = _HasColumn(reader, "CreatedAt") ? reader["CreatedAt"] as DateTime? : null
            };
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

        /// <summary>
        /// Calls SP_Role_GetAll. Returns the full list of roles (Admin/Librarian/Member by default seed).
        /// </summary>
        public static List<RoleDTO> GetAllRoles()
        {
            List<RoleDTO> roles = new List<RoleDTO>();

            using (SqlConnection connection = clsDataAccessSettings.GetConnection())
            using (SqlCommand command = new SqlCommand("SP_Role_GetAll", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                try
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            roles.Add(_MapReaderToRole(reader));
                        }
                    }
                }
                catch (SqlException ex)
                {
                    Console.WriteLine("GetAllRoles error: " + ex.Message);
                }
            }

            return roles;
        }
    }
}
