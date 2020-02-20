using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace StallManagementSystem
{
    class usersClass : Connection
    {
        public void getUsers()
        {
            sqlQuery("SELECT * FROM users_tbl");
            closeConn();
        }

        public void searchUsers(string searchedName)
        {
            sqlQuery("SELECT * FROM users_tbl WHERE CONCAT(lastname,' ', firstname,' ', middlename) LIKE @searched");
            _cmd.Parameters.AddWithValue("@searched", "%" + searchedName + "%");
            closeConn();
        }

        public void updateUsers(string username, string password, string firstname, string middlename, string lastname, string usertype, string status, string userid)
        {
            sqlQuery(
                        "UPDATE users_tbl SET firstname = @firstname, lastname = @lastname, middlename = @middlename, username = @username, password = @password, usertype = @usertype, status = @status WHERE user_id = @user_id"
                    );

            _cmd.Parameters.AddWithValue("@firstname", firstname);
            _cmd.Parameters.AddWithValue("@lastname", lastname);
            _cmd.Parameters.AddWithValue("@middlename", middlename);
            _cmd.Parameters.AddWithValue("@username", username);
            _cmd.Parameters.AddWithValue("@password", password);
            _cmd.Parameters.AddWithValue("@usertype", usertype);
            _cmd.Parameters.AddWithValue("@status", status);
            _cmd.Parameters.AddWithValue("@user_id", userid);
            int result = _cmd.ExecuteNonQuery();
            closeConn();

            if (result < 0)
            {
                MessageBox.Show("Failed!");
            }
            else
            {
                MessageBox.Show("Updated!");
            }
        }
    }
}
