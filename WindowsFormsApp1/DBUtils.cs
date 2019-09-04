using System;
using System.Collections.Generic;
using System.Data.Entity.Core.EntityClient;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class DBUtils
    {

        static string datasource = @"DESKTOP-HVKP5SN\SQLEXPRESS";
        static string database = "The_State_Duma_3";
        static string username = "sa";
        static string password = "1234";

        private static string _CONNECTION_STRING_ = "";

        public static void setLoginPassword(string u, string p)
        {
            username = u;
            password = p;

            _CONNECTION_STRING_ = "";
        }

        public static string getConnString()
        {
            if (_CONNECTION_STRING_.Length == 0)
            {
                //Build an SQL connection string
                SqlConnectionStringBuilder sqlString = new SqlConnectionStringBuilder()
                {
                    DataSource = @"DESKTOP-HVKP5SN\SQLEXPRESS", // Server name
                    InitialCatalog = "The_State_Duma_3",  //Database
                    UserID = username,         //Username
                    Password = password,  //Password
                    MultipleActiveResultSets = true,
                    ApplicationName = "EntityFramework",
                };
                //Build an Entity Framework connection string
                EntityConnectionStringBuilder entityString = new EntityConnectionStringBuilder()
                {
                    Provider = "System.Data.SqlClient",
                    Metadata = "res://*/The_State_Duma_Model.csdl|res://*/The_State_Duma_Model.ssdl|res://*/The_State_Duma_Model.msl",
                    ProviderConnectionString = sqlString.ToString(),
                };
                _CONNECTION_STRING_ = entityString.ConnectionString;
            }
            return _CONNECTION_STRING_;
        }
        
    }
}
