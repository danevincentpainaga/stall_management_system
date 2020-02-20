using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StallManagementSystem
{
    class dueDateClass : Connection
    {
        public dueDateClass()
        {
            var _date = DateTime.Now.ToShortDateString();
            sqlQuery(
                        "SELECT sc.*, s.* FROM stall_contract sc "+
                        "INNER JOIN stalls_tbl s ON sc.stallId = s.stall_id " +
                        "WHERE sc.due_date = @date AND sc.contract_status != 'Terminated' AND sc.contract_status != 'Pending'"
                    );
            _cmd.Parameters.AddWithValue("@date", _date);
            closeConn();
            if (QueryExe().Rows.Count > 0)
            {
                validate(QueryExe());
            }
        }

        public void validate(DataTable d)
        {
            sqlQuery(
                        "SELECT * FROM billings_tbl WHERE stall_contractId = @stall_contractId AND until_date = @until_date"
                    );

            foreach (DataRow dr in d.Rows)
            {
                _cmd.Parameters.Clear();
                _cmd.Parameters.AddWithValue("@stall_contractId", dr["stall_contract_id"].ToString());
                _cmd.Parameters.AddWithValue("@until_date", dr["due_date"].ToString());
            }

            closeConn();
            if (QueryExe().Rows.Count == 0)
            {
                updateDueDateAndBalance(d);
            }
        }

        public void updateDueDateAndBalance(DataTable d)
        {
            int result = -1;
            sqlQuery("UPDATE stall_contract SET total_balance = @total_balance, due_date = @due_date WHERE stall_contract_id = @contractId");
            foreach (DataRow dr in d.Rows)
            {
                _cmd.Parameters.Clear();
                DateTime newdate = Convert.ToDateTime(dr["due_date"]);
                double interest = Convert.ToInt32(dr["rate"]) * 0.25;
                string total = Convert.ToString(Convert.ToInt32(dr["rate"]) + interest);
                _cmd.Parameters.AddWithValue("@total_balance", total);
                _cmd.Parameters.AddWithValue("@due_date", newdate.AddMonths(1).ToString("dd/MM/yyyy"));
                _cmd.Parameters.AddWithValue("@contractId", dr["stall_contract_id"].ToString());
                result = _cmd.ExecuteNonQuery();
            }
            closeConn();
            if (result < 0)
            {
                MessageBox.Show("Failed!");
            }
            else
            {
                insertDuePauments(d);
            }
        }


        public void insertDuePauments(DataTable d)
        {
            int result = -1;
            sqlQuery(
                        "INSERT INTO billings_tbl(stall_contractId, from_date, until_date, total_amount, interest, total_paid, status) " +
                        "VALUES " +
                        "(@stall_contractId, @from_date, @until_date, @total_amount, @interest, @total_paid, @status)"
                    );

            foreach (DataRow dr in d.Rows)
            {
                _cmd.Parameters.Clear();
                string interest = Convert.ToString(Convert.ToInt32(dr["rate"]) * 0.25);
                _cmd.Parameters.AddWithValue("@stall_contractId", dr["stall_contract_id"].ToString());
                _cmd.Parameters.AddWithValue("@from_date", dr["start_date"].ToString());
                _cmd.Parameters.AddWithValue("@until_date", dr["due_date"].ToString());
                _cmd.Parameters.AddWithValue("@total_amount", dr["rate"].ToString());
                _cmd.Parameters.AddWithValue("@interest", interest);
                _cmd.Parameters.AddWithValue("@total_paid", "0");
                _cmd.Parameters.AddWithValue("@status", "unpaid");
                result = _cmd.ExecuteNonQuery();
            }
            closeConn();
            if (result < 0)
            {
                MessageBox.Show("Failed!");
            }
            else
            {
                MessageBox.Show("Success");
            }
        }
    }
}
