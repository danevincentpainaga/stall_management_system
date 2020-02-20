using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StallManagementSystem
{
    class paymentsClass : contractsClass
    {
        public void getLesseePaymentDetails()
        {
            sqlQuery(
                       "SELECT sc.*, l.* FROM stall_contract sc " +
                       "LEFT JOIN lessees_tbl l ON l.lessee_id = sc.lesseeId " +
                       "WHERE total_balance != 0 " +
                       "AND sc.contract_status != 'Terminated' AND sc.contract_status != 'Pending'" +
                       "GROUP BY lesseeId"
                    );
            closeConn();
        }

        public void searchLesseePaymentDetails(string searchedName)
        {
            sqlQuery(
                       "SELECT sc.*, l.* FROM stall_contract sc " +
                       "LEFT JOIN lessees_tbl l ON l.lessee_id = sc.lesseeId " +
                       "WHERE total_balance != 0 " +
                       "AND sc.contract_status = 'Active' AND CONCAT(l_lastname,' ', l_firstname,' ', l_middlename) LIKE @searched " +
                       "GROUP BY lesseeId"
                    );
            _cmd.Parameters.AddWithValue("@searched", "%" + searchedName + "%");
            closeConn();
        }

        public void getFullyPaidLessees()
        {
            sqlQuery(
                       "SELECT sc.*, l.* FROM stall_contract sc " +
                       "LEFT JOIN lessees_tbl l ON l.lessee_id = sc.lesseeId " +
                       "INNER JOIN stalls_tbl s ON sc.stallId = s.stall_id " +
                       "WHERE total_balance = 0 " +
                       "AND sc.contract_status = 'Active'" +
                       "GROUP BY lesseeId"
                    );
            closeConn();
        }

        public void searchFullyPaidLessees(string searchedName)
        {
            sqlQuery(
                       "SELECT sc.*, l.* FROM stall_contract sc " +
                       "LEFT JOIN lessees_tbl l ON l.lessee_id = sc.lesseeId " +
                       "INNER JOIN stalls_tbl s ON sc.stallId = s.stall_id " +
                       "WHERE total_balance = 0 " +
                       "AND sc.contract_status = 'Active' AND CONCAT(l_lastname,' ', l_firstname,' ', l_middlename) LIKE @searched " +
                       "GROUP BY lesseeId"
                    );
            _cmd.Parameters.AddWithValue("@searched", "%" + searchedName + "%");
            closeConn();
        }

        public void getLesseeNotFullPaymentRentedStalls(string lid)
        {
            sqlQuery(
                       "SELECT l.*, sc.*, s.* FROM lessees_tbl l " +
                       "INNER JOIN stall_contract sc ON l.lessee_id = sc.lesseeId " +
                       "INNER JOIN stalls_tbl s ON sc.stallId = s.stall_id " +
                       "WHERE lesseeId = @lessee_id " +
                       "AND sc.total_balance != 0 AND sc.contract_status != 'Terminated' AND sc.contract_status != 'Pending'"
                    );
            _cmd.Parameters.AddWithValue("@lessee_id", lid);
            closeConn();
        }

        public void getLesseeUnpaidPayments(string contract_id)
        {
            sqlQuery("SELECT * FROM billings_tbl WHERE stall_contractId = @contract_id AND total_paid = 0");
            _cmd.Parameters.AddWithValue("@contract_id", contract_id);
            closeConn();
        }

        public void payMonthlyBills(List<string> dates, string contractId, string amount, string lessee)
        {
            int result = -1;
            sqlQuery("UPDATE billings_tbl SET total_paid = total_amount + interest, status = 'paid', date_paid = @date_paid WHERE until_date = @dates AND stall_contractId = @contractId");

            for (int i = 0; i < dates.Count; i++)
            {
                _cmd.Parameters.Clear();
                _cmd.Parameters.AddWithValue("@dates", dates[i]);
                _cmd.Parameters.AddWithValue("@contractId", contractId);
                _cmd.Parameters.AddWithValue("@date_paid", DateTime.Now.ToShortDateString());
                result = _cmd.ExecuteNonQuery();
            }
            closeConn();
            if (result < 0)
            {
                MessageBox.Show("Failed!");
            }
            else
            {
                deductBalance(amount, contractId, dates[dates.Count - 1], lessee);
            }
        }

        public void deductBalance(string amount, string contractId, string dueDate, string lessee)
        {
            sqlQuery("UPDATE stall_contract SET total_balance = total_balance - @amount, due_date = @due_date WHERE stall_contract_id = @contractId");
            _cmd.Parameters.AddWithValue("@amount", amount);
            _cmd.Parameters.AddWithValue("@contractId", contractId);
            _cmd.Parameters.AddWithValue("@due_date", dueDate);
            int result = _cmd.ExecuteNonQuery();
            closeConn();
            if (result < 0)
            {
                MessageBox.Show("Failed!");
            }
            else
            {
                new RecieptForm(lessee, amount).ShowDialog();
                MessageBox.Show("Updated!");
            }
        }

        public void advancePayment(string total_contract, string contractId, string dueDate, string from_date, string lessee)
        {
            sqlQuery("UPDATE stall_contract SET due_date = @due_date, last_month_paid = @last_month_paid, total_contract = @total_contract WHERE stall_contract_id = @contractId");
            _cmd.Parameters.AddWithValue("@total_contract", total_contract);
            _cmd.Parameters.AddWithValue("@contractId", contractId);
            _cmd.Parameters.AddWithValue("@last_month_paid", dueDate);
            _cmd.Parameters.AddWithValue("@due_date", dueDate);
            int result = _cmd.ExecuteNonQuery();
            closeConn();
            if (result < 0)
            {
                MessageBox.Show("Failed!");
            }
            else
            {
                savePaymentDetails(contractId, from_date, dueDate, total_contract, lessee);
            }
        }

        private void savePaymentDetails(string stall_contractId, string from_date, string until_date, string total_amount, string lessee)
        {
            sqlQuery(
                        "INSERT INTO billings_tbl(stall_contractId, from_date, until_date, total_amount, total_paid, status, date_paid) " +
                        "VALUES " +
                        "(@stall_contractId, @from_date, @until_date, @total_amount, @total_paid, @status, @date_paid)"
                    );
            _cmd.Parameters.AddWithValue("@stall_contractId", stall_contractId);
            _cmd.Parameters.AddWithValue("@from_date", from_date);
            _cmd.Parameters.AddWithValue("@until_date", until_date);
            _cmd.Parameters.AddWithValue("@total_amount", total_amount);
            _cmd.Parameters.AddWithValue("@total_paid", total_amount);
            _cmd.Parameters.AddWithValue("@status", "paid");
            _cmd.Parameters.AddWithValue("@date_paid", DateTime.Now.ToShortDateString());
            int result = _cmd.ExecuteNonQuery();
            closeConn();
            if (result < 0)
            {
                MessageBox.Show("Failed!");
            }
            else
            {
                new RecieptForm(lessee, total_amount).ShowDialog();
                MessageBox.Show("Updated!");
            }
        }

        public void payAmbulantTickets(string lesseeeId, string amount)
        {
            sqlQuery(
                        "INSERT INTO ambulant_sales(lesseeId, amount, date_paid) " +
                        "VALUES " +
                        "(@lesseeeId, @amount, @date_paid)"
                    );
            _cmd.Parameters.AddWithValue("@lesseeeId", lesseeeId);
            _cmd.Parameters.AddWithValue("@amount", amount);
            _cmd.Parameters.AddWithValue("@date_paid", DateTime.Now.ToShortDateString());
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
