using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace StallManagementSystem
{
    class stallClass : lesseesClass
    {
        public void getStalls()
        {
            sqlQuery("SELECT * FROM stalls_tbl");
            closeConn();
        }

        public void searchStalls(string stall)
        {
            sqlQuery("SELECT * FROM stalls_tbl WHERE stall_number LIKE @searched");
            _cmd.Parameters.AddWithValue("@searched", "%" + stall);
            closeConn();
        }


        public void getAvailableStalls()
        {
            sqlQuery("SELECT * FROM stalls_tbl WHERE stall_status = 'Available'");
            closeConn();
        }

        public void getRentedStalls()
        {
            sqlQuery("SELECT * FROM stalls_tbl WHERE stall_status = 'Rented'");
            closeConn();
        }

        public void getReservedStalls()
        {
            sqlQuery("SELECT * FROM stalls_tbl WHERE stall_status = 'Reserved'");
            closeConn();
        }

        public Boolean validateStallNumhber(string stallnumber)
        {
            sqlQuery("SELECT * FROM stalls_tbl WHERE stall_number = @stall_number");
            _cmd.Parameters.AddWithValue("@stall_number", stallnumber);
            closeConn();
            if (QueryExe().Rows.Count > 0)
            {
                return false;
            }
            return true;
        }

        public void saveNewStall(Dictionary<string, string> stall, StallsUserControl s)
        {
            if (this.validateStallNumhber(stall["stall_number"]))
            {
                sqlQuery(
                            "INSERT INTO stalls_tbl(stall_number, rate, stall_floor_alength, stall_floor_blength, stall_status) " +
                            "VALUES "+
                            "(@stall_number, @rate, @stall_floor_alength, @stall_floor_blength, @stall_status)"
                        );

                _cmd.Parameters.AddWithValue("@stall_number", stall["stall_number"]);
                _cmd.Parameters.AddWithValue("@rate", stall["rate"]);
                _cmd.Parameters.AddWithValue("@stall_floor_alength", stall["stall_floor_alength"]);
                _cmd.Parameters.AddWithValue("@stall_floor_blength", stall["stall_floor_blength"]);
                _cmd.Parameters.AddWithValue("@stall_status", "Available");
                int result = _cmd.ExecuteNonQuery();
                closeConn();

                if (result < 0)
                {
                    MessageBox.Show("Failed!");
                }
                else
                {
                    s.displayStalls();
                    MessageBox.Show("Saved!");
                }
            }
            else
            {
                MessageBox.Show("Stall already exist");
            }
        }

        public void updateStall(Dictionary<string, string> stall)
        {
            sqlQuery(
                        "UPDATE stalls_tbl SET "+
                        "stall_number = @stall_number, rate = @rate, stall_floor_alength = @stall_floor_alength, "+
                        "stall_floor_blength = @stall_floor_blength "+
                        "WHERE stall_id = @stall_id"
                    );

            _cmd.Parameters.AddWithValue("@stall_number", stall["stall_number"]);
            _cmd.Parameters.AddWithValue("@rate", stall["rate"]);
            _cmd.Parameters.AddWithValue("@stall_floor_alength", stall["stall_floor_alength"]);
            _cmd.Parameters.AddWithValue("@stall_floor_blength", stall["stall_floor_blength"]);
            _cmd.Parameters.AddWithValue("@stall_id", stall["stall_id"]);
            int result = _cmd.ExecuteNonQuery();
            closeConn();
            if (result < 0)
            {
                MessageBox.Show("Failed!","", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Stall updated!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
