using LibrarySystem_DL;
using System.Linq;

namespace LibrarySystem_BL
{
    /// <summary>
    /// Read-only BL wrapper — only SP_Role_GetAll exists in the DL, so there's no
    /// Save()/Delete() here. Roles are seeded directly in SQL (Admin/Librarian/Member).
    /// </summary>
    public class Roles
    {
        public int? RoleID { get; private set; }
        public string? RoleName { get; private set; }
        public string? Description { get; private set; }
        public int? Permission { get; private set; }
        public DateTime? CreatedAt { get; private set; }

        public Roles() { }

        public Roles(RoleDTO roleDTO)
        {
            RoleID = roleDTO.RoleID;
            RoleName = roleDTO.RoleName;
            Description = roleDTO.Description;
            Permission = roleDTO.Permission;
            CreatedAt = roleDTO.CreatedAt;
        }

        /// <summary>
        /// Checks whether this role has a given permission bit set.
        /// Example: role.HasPermission(enPermission.BookDelete)
        /// </summary>
        public bool HasPermission(enPermission permission)
        {
            if (Permission == null) return false;
            return (Permission.Value & (int)permission) == (int)permission;
        }

        /// <summary>
        /// Loads all roles defined in the system.
        /// </summary>
        public static List<Roles> GetAll()
        {
            List<RoleDTO> dtos = RolesData.GetAllRoles();
            List<Roles> result = new List<Roles>();

            foreach (RoleDTO dto in dtos)
                result.Add(new Roles(dto));

            return result;
        }

        /// <summary>
        /// Convenience lookup — finds a single role by ID from the full list.
        /// (There's no SP_Role_GetByID in the DL, so this filters client-side.)
        /// </summary>
        public static Roles? Find(int roleID)
        {
            return GetAll().FirstOrDefault(r => r.RoleID == roleID);
        }
    }
}
