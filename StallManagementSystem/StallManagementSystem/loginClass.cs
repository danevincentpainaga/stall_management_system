using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace StallManagementSystem
{
    class loginClass : Connection
    {
        public static string userid, loggedUsername, user_type, loggedFullname;

        public int validate(string username, string password)
        {
            int isSuccess = 0;
            try
            {
                sqlQuery("SELECT * FROM users_tbl WHERE username = @username AND password = @password AND status = 'Activated'");
                _cmd.Parameters.AddWithValue("@username", username);
                _cmd.Parameters.AddWithValue("@password", password);
                if (QueryExe().Rows.Count == 1)
                {
                    foreach (DataRow dr in QueryExe().Rows)
                    {
                        userid = dr["user_id"].ToString();
                        user_type = dr["usertype"].ToString();
                        loggedUsername = dr["username"].ToString();
                        loggedFullname = dr["firstname"].ToString() + " " + dr["middlename"].ToString() + ". " + dr["lastname"].ToString();
                    }
                    isSuccess = 1;
                }
                else
                {
                    isSuccess = 0;
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

            return isSuccess;
        }
    }
}
