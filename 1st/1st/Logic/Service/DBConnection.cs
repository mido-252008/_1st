using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace _1st.Logic.Service
{
    static class DBConnection
    {
        static SqlConnection GetConnectionString()
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.InitialCatalog = _1st.Properties.Settings.Default.Server;
            builder.DataSource = _1st.Properties.Settings.Default.DataBase;
            builder.IntegratedSecurity = _1st.Properties.Settings.Default.IntegratedSecurity;
            builder.UserID = _1st.Properties.Settings.Default.DBUserName;
            builder.Password = _1st.Properties.Settings.Default.DBPassword;
            return new SqlConnection(builder.ConnectionString);
        }
 
        static bool ExecuteData(string SP,Action action)
        {
            using (SqlConnection cn = GetConnectionString())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand(SP, cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    action.Invoke();
                    cn.Open();
                    cmd.ExecuteNonQuery();
                    cn.Close();
                    return true;
                }
                catch (Exception ex)
                {
                    cn.Close();
                    Console.Write(ex.Message);
                    return false;
                }
            }
        }
    }
}