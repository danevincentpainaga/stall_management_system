using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace StallManagementSystem
{
    class addUserClass: Connection
    {
        public void addUsers(string username, string password, string firstname, string middlename, string lastname, string usertype, string status)
        {
            sqlQuery(
                        "INSERT INTO users_tbl(firstname, lastname, middlename, username, password, usertype, status) " +
                        "VALUES "+
                        "(@firstname, @lastname, @middlename, @username, @password, @usertype, @status)"
                    );

            _cmd.Parameters.AddWithValue("@firstname", firstname);
            _cmd.Parameters.AddWithValue("@lastname", lastname);
            _cmd.Parameters.AddWithValue("@middlename", middlename);
            _cmd.Parameters.AddWithValue("@username", username);
            _cmd.Parameters.AddWithValue("@password", password);
            _cmd.Parameters.AddWithValue("@usertype", usertype);
            _cmd.Parameters.AddWithValue("@status", status);
            int result = _cmd.ExecuteNonQuery();
            closeConn();

            if (result < 0)
            {
                MessageBox.Show("Failed!");
            }
            else
            {
                MessageBox.Show("Saved!");
            }
        }
    }
}
