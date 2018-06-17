using System;
using System.Data;
using System.Data.SqlClient;
using UserAccess.Models;
namespace UserAccess.Forms.Common
{
    public class SqlQueryWithString
    {
        public static void Query(USERINFO updateCheckbox, string queryUpdateCheckbox,SettingsDbContent nameofDatabaseSettings,string machineName)
        {
            SqlConnection con = new SqlConnection(string.Format(GlobalConstants.ConnectionStringToAx, machineName, nameofDatabaseSettings.NameOfDatabase));
            con.Open();

            SqlCommand cmd = new SqlCommand(string.Format(queryUpdateCheckbox,nameofDatabaseSettings.NameOfDatabase, updateCheckbox.NAME));
            cmd.Connection = con;
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            DataTable dbTable = new DataTable();
            dataAdapter.Fill(dbTable);
        }

        //public static void QueryToAppDb(SYSUSERLOG SYSUSERLOG,string queryUpdateLogOutTime,long RECID,string machineName,DateTime LOGOUT)
        //{
        //    SqlConnection con = new SqlConnection(string.Format(GlobalConstants.ConnectionStringAccessServer, machineName));
        //    con.Open();
        //
        //    SqlCommand cmd = new SqlCommand(string.Format(queryUpdateLogOutTime, LOGOUT, RECID));
        //    cmd.Connection = con;
        //    SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
        //    DataTable dbTable = new DataTable();
        //    dataAdapter.Fill(dbTable);
        //}  
    }
}
 