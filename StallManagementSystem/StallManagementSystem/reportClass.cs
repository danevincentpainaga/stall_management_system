using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace StallManagementSystem
{
    class reportClass : Connection
    {
        public void getLesseeMonthlyReports(string month, string year)
        {
                sqlQuery(
                           "SELECT l.*, sc.*, s.*, b.* FROM billings_tbl b " +
                           "INNER JOIN stall_contract sc ON b.stall_contractId = sc.stall_contract_id " +
                           "INNER JOIN stalls_tbl s ON sc.stallId = s.stall_id " +
                           "INNER JOIN lessees_tbl l ON sc.lesseeId = l.lessee_id " +
                           "WHERE MONTHNAME(STR_TO_DATE(b.date_paid, '%d/%m/%Y')) = @month AND status = 'paid' AND YEAR(STR_TO_DATE(b.date_paid, '%d/%m/%Y')) = @year " +
                           "AND l.lessee_type = 'lessee'"
                        );
            
            _cmd.Parameters.AddWithValue("@month", month);
            _cmd.Parameters.AddWithValue("@year", year);
            closeConn();
        }

        public void getAmbulantMonthlyReports(string month, string year)
        {
            sqlQuery(
                       "SELECT l.*, a.* FROM ambulant_sales a " +
                       "INNER JOIN lessees_tbl l ON a.lesseeId = l.lessee_id " +
                       "WHERE MONTHNAME(STR_TO_DATE(a.date_paid, '%d/%m/%Y')) = @month AND YEAR(STR_TO_DATE(a.date_paid, '%d/%m/%Y')) = @year " +
                       "AND l.lessee_type = 'ambulant'"
                    );
            _cmd.Parameters.AddWithValue("@month", month);
            _cmd.Parameters.AddWithValue("@year", year);
            closeConn();
        }
    }
}
