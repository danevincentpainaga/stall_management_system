using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace StallManagementSystem
{
    class contractsClass : lesseesClass
    {
        public contractsClass()
        {

        }

        public void getLesseeRentedStalls(string lid)
        {
            sqlQuery(
                       "SELECT l.*, sc.*, s.* FROM lessees_tbl l " +
                       "INNER JOIN stall_contract sc ON l.lessee_id = sc.lesseeId " +
                       "INNER JOIN stalls_tbl s ON sc.stallId = s.stall_id " +
                       "WHERE lesseeId = @lessee_id AND sc.contract_status = 'Active'"
                    );
            _cmd.Parameters.AddWithValue("@lessee_id", lid);
        }

        public void getPendingLesseeRentedStalls(string lid)
        {
            sqlQuery(
                       "SELECT l.*, sc.*, s.* FROM lessees_tbl l " +
                       "INNER JOIN stall_contract sc ON l.lessee_id = sc.lesseeId " +
                       "INNER JOIN stalls_tbl s ON sc.stallId = s.stall_id " +
                       "WHERE lesseeId = @lessee_id AND sc.contract_status = 'Pending'"
                    );
            _cmd.Parameters.AddWithValue("@lessee_id", lid);
        }

        public void getFullyPaidLesseeRentedStalls(string lid)
        {
            sqlQuery(
                       "SELECT l.*, sc.*, s.* FROM lessees_tbl l " +
                       "INNER JOIN stall_contract sc ON l.lessee_id = sc.lesseeId " +
                       "INNER JOIN stalls_tbl s ON sc.stallId = s.stall_id " +
                       "WHERE lesseeId = @lessee_id AND sc.total_balance = 0 "+
                       "AND sc.contract_status != 'Terminated' AND sc.contract_status != 'Pending'"
                    );
            _cmd.Parameters.AddWithValue("@lessee_id", lid);
        }

        public void getActiveContracts()
        {
            sqlQuery(
                       "SELECT sc.*, l.* FROM stall_contract sc " +
                       "LEFT JOIN lessees_tbl l ON l.lessee_id = sc.lesseeId "+
                       "WHERE sc.contract_status = 'Active' " +
                       "GROUP BY lesseeId"
                    );
            closeConn();
        }
        
        public void searchActiveContracts(string searchedName)
        {
            sqlQuery(
                       "SELECT sc.*, l.* FROM stall_contract sc " +
                       "LEFT JOIN lessees_tbl l ON l.lessee_id = sc.lesseeId " +
                       "WHERE sc.contract_status = 'Active' AND CONCAT(l_lastname,' ', l_firstname,' ', l_middlename) LIKE @searched "+
                       "GROUP BY lesseeId"
                    );
            _cmd.Parameters.AddWithValue("@searched", "%"+ searchedName + "%");
            closeConn();
        }

        public void getPendingContracts()
        {
            sqlQuery(
                       "SELECT sc.*, l.* FROM stall_contract sc " +
                       "LEFT JOIN lessees_tbl l ON l.lessee_id = sc.lesseeId " +
                       "WHERE sc.contract_status = 'Pending' " +
                       "GROUP BY lesseeId"
                    );
            closeConn();
        }

        public void searchPendingContracts(string searchedName)
        {
            sqlQuery(
                       "SELECT sc.*, l.* FROM stall_contract sc " +
                       "LEFT JOIN lessees_tbl l ON l.lessee_id = sc.lesseeId " +
                       "WHERE sc.contract_status = 'Pending' AND CONCAT(l.l_lastname,' ', l.l_firstname,' ', l.l_middlename) LIKE @searched "
                    );
            _cmd.Parameters.AddWithValue("@searched", "%" + searchedName + "%");
            closeConn();
        }

        public void terminatedContracts()
        {
            sqlQuery(
                       "SELECT  l.l_lastname, l.l_firstname, l.l_middlename, l.gender, l.address, s.stall_number, sc.start_date, sc.due_date, s.rate, sc.contract_status FROM stall_contract sc " +
                       "LEFT JOIN lessees_tbl l ON l.lessee_id = sc.lesseeId " +
                       "LEFT JOIN stalls_tbl s ON sc.stallId = s.stall_id " +
                       "WHERE sc.contract_status = 'Terminated' "
                    );
            closeConn();
        }

        public void searchTerminatedContracts(string searchedName)
        {
            sqlQuery(
                       "SELECT  l.l_lastname, l.l_firstname, l.l_middlename, l.gender, l.address, s.stall_number, sc.start_date, sc.due_date, s.rate, sc.contract_status FROM stall_contract sc " +
                       "LEFT JOIN lessees_tbl l ON l.lessee_id = sc.lesseeId " +
                       "LEFT JOIN stalls_tbl s ON sc.stallId = s.stall_id " +
                       "WHERE sc.contract_status = 'Terminated' AND CONCAT(l_lastname,' ', l_firstname,' ', l_middlename) LIKE @searched "
                    );
            _cmd.Parameters.AddWithValue("@searched", "%" + searchedName + "%");
            closeConn();
        }

        public void getContracts(string stall_status)
        {
            sqlQuery(
                       "SELECT s.stall_number, s.stall_status, l.l_lastname, l.l_firstname, l.l_middlename, l.gender, l.address, sc.start_date, sc.due_date, s.rate, sc.contract_status FROM stall_contract sc " +
                       "LEFT JOIN lessees_tbl l ON l.lessee_id = sc.lesseeId " +
                       "LEFT JOIN stalls_tbl s ON sc.stallId = s.stall_id " +
                       "WHERE sc.contract_status != 'Terminated' AND stall_status LIKE @stall_status "
                    );
            _cmd.Parameters.AddWithValue("@stall_status", "%" + stall_status);
            closeConn();
        }

        public void getContractsByStallNumber(string stall_status, string stall_id)
        {
            sqlQuery(
                       "SELECT s.stall_number, s.stall_status, l.l_lastname, l.l_firstname, l.l_middlename, l.gender, l.address, sc.start_date, sc.due_date, s.rate, sc.contract_status FROM stall_contract sc " +
                       "LEFT JOIN lessees_tbl l ON l.lessee_id = sc.lesseeId " +
                       "LEFT JOIN stalls_tbl s ON sc.stallId = s.stall_id " +
                       "WHERE sc.contract_status != 'Terminated' AND stall_status LIKE @stall_status AND s.stall_id = @stall_id"
                    );
            _cmd.Parameters.AddWithValue("@stall_status", "%" + stall_status);
            _cmd.Parameters.AddWithValue("@stall_id", stall_id);
            closeConn();
        }

        public void approvedContracts(string stall_contract_id, string stall_id)
        {
            sqlQuery(
                        "UPDATE stall_contract SET " +
                        "date_approved = @date_approved, contract_status = @contract_status " +
                        "WHERE stall_contract_id = @stall_contract_id"
                    );

            _cmd.Parameters.AddWithValue("@stall_contract_id", stall_contract_id);
            _cmd.Parameters.AddWithValue("@date_approved", DateTime.Now.ToShortDateString());
            _cmd.Parameters.AddWithValue("@contract_status", "Active");
            int result = _cmd.ExecuteNonQuery();
            closeConn();

            if (result < 0)
            {
                MessageBox.Show("Failed!");
            }
            else
            {
                updateStallStatus(stall_id);
            }
        }

        private void updateStallStatus(string stall_id)
        {
            sqlQuery("UPDATE stalls_tbl SET stall_status = 'Rented' WHERE stall_id = @stall_id");
            _cmd.Parameters.AddWithValue("@stall_id", stall_id);
            int result = _cmd.ExecuteNonQuery();
            closeConn();

            if (result < 0)
            {
                MessageBox.Show("Failed!");
            }
            else
            {
                MessageBox.Show("Contract Approved!");
            }
        }

        public void declineContracts(string stall_contract_id)
        {
            sqlQuery("DELETE FROM stall_contract WHERE stall_contract_id = @stall_contract_id");
            _cmd.Parameters.AddWithValue("@stall_contract_id", stall_contract_id);
            int result = _cmd.ExecuteNonQuery();

            if (result < 0)
            {
                MessageBox.Show("Failed!");
            }
            else
            {
                MessageBox.Show("Contract Declined!");
            }
            closeConn();
        }

        public void terminateContracts(string stall_contract_id, string stall_id)
        {
            sqlQuery("UPDATE stall_contract SET contract_status = @contract_status WHERE stall_contract_id = @stall_contract_id");
            _cmd.Parameters.AddWithValue("@stall_contract_id", stall_contract_id);
            _cmd.Parameters.AddWithValue("@contract_status", "Terminated");
            int result = _cmd.ExecuteNonQuery();
            closeConn();
            if (result < 0)
            {
                MessageBox.Show("Failed!");
            }
            else
            {
                setStallToAvailable(stall_id);
            }
        }

        public void setStallToAvailable(string stall_id)
        {
            sqlQuery("UPDATE stalls_tbl SET stall_status = 'Available' WHERE stall_id = @stall_id");
            _cmd.Parameters.AddWithValue("@stall_id", stall_id);
            int result = _cmd.ExecuteNonQuery();

            if (result < 0)
            {
                MessageBox.Show("Failed!");
            }
            else
            {
                MessageBox.Show("Contract Terminated!");
            }
            closeConn();
        }
    }
}
