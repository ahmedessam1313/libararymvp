using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libaraymvp.Logic.services
{
   static class dbhelper
    {
        public static SqlCommand command;
        //this method to get connection string from sql server
        private static SqlConnection getconnectionstring()
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = Properties.Settings.Default.servername;
            builder.InitialCatalog = Properties.Settings.Default.databasename;
            //builder.UserID = "admin";
            //builder.Password = "123";
            builder.IntegratedSecurity = true;
            return new SqlConnection(builder.ConnectionString);
        }
        //this method to make insert and update and delete
        public static bool excutedata(string spname,Action method)
        {
            using (SqlConnection connection = getconnectionstring() )
            {
                try
                {
                    command = new SqlCommand(spname, connection);
                    command.CommandType = CommandType.StoredProcedure;

                    //to excute method that contain parameters
                    method.Invoke();

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                    return true;
                }
                catch (Exception ex)
                {
                    connection.Close();
                    Console.WriteLine(ex.Message);
                    return false;
                }
                finally
                {
                    connection.Close();
                }
            }
            return false;
        }
        

    }
}
