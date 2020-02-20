using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace StallManagementSystem
{
    class applicationClass : Connection
    {

        public void addPendingContract(Dictionary<string, string> row)
        {
            sqlQuery(
                        "INSERT INTO stall_contract(lesseeId, stallId, start_date, due_date, date_created, total_balance, business_permit, fire_clearance, police_clearance, nbi_clearance, total_contract, contract_status) " +
                        "VALUES " +
                        "(@lesseeId, @stallId, @start_date, @due_date, @date_created, @total_balance, @business_permit, @fire_clearance, @police_clearance, @nbi_clearance, @total_contract,  @contract_status)"
                    );

            _cmd.Parameters.AddWithValue("@lesseeId", row["lesseeId"]);
            _cmd.Parameters.AddWithValue("@stallId", row["stallId"]);
            _cmd.Parameters.AddWithValue("@start_date", row["start_date"]);
            _cmd.Parameters.AddWithValue("@due_date", row["due_date"]);
            _cmd.Parameters.AddWithValue("@date_created", row["date_created"]);
            _cmd.Parameters.AddWithValue("@total_balance", "0");
            _cmd.Parameters.AddWithValue("@business_permit", row["business_permit"]);
            _cmd.Parameters.AddWithValue("@fire_clearance", row["fire_clearance"]);
            _cmd.Parameters.AddWithValue("@police_clearance", row["police_clearance"]);
            _cmd.Parameters.AddWithValue("@nbi_clearance", row["nbi_clearance"]);
            _cmd.Parameters.AddWithValue("@total_contract", row["total_contract"]);
            _cmd.Parameters.AddWithValue("@contract_status", "Pending");
            NonQueryExe();
            closeConn();
            updateStallStatus(row["stallId"]);
        }


        private void updateStallStatus(string stall_id)
        {
            sqlQuery("UPDATE stalls_tbl SET stall_status = 'Reserved' WHERE stall_id = @stall_id");
            _cmd.Parameters.AddWithValue("@stall_id", stall_id);
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
