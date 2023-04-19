using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DataVisualizerClassLibrary
{
    public class DatabaseAccess
    {
        public DatabaseAccess() 
        {
            // TODO load users in form else where
            // TODO create database file .db and make sure table for Users the columns are correct for select all command
            static List<User.EndUser> LoadUsers()
            {
                using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
                {
                    var output = cnn.Query<User.EndUser>("select *");
                    return output.ToList();
                }
            }
        }

        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
