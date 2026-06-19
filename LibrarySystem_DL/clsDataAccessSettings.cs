using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem_DL
{
    internal class clsDataAccessSettings
    {
        public static string ConnectionString = "Server=localhost;Database=LibraryManagement;User Id=sa;Password=123456;Encrypt=False;TrustServerCertificate=True;Connection Timeout=30;";// TODO: replace with your real connection string (or load from appsettings.json / App.config)
      
        public static SqlConnection GetConnection()
        {
            return new SqlConnection(ConnectionString);
        }

    }
}
