using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace StallManagementSystem
{
    class billingClass : Connection
    {
        public void getHasRemainingBalanceLessees()
        {
            sqlQuery(
                       "SELECT CONCAT(l.l_firstname, ', ' ,l.l_firstname,' ', l.l_middlename) as Name, s.stall_number, sc.total_balance FROM stall_contract sc " +
                       "LEFT JOIN lessees_tbl l ON l.lessee_id = sc.lesseeId " +
                       "LEFT JOIN stalls_tbl s ON s.stall_id = sc.stallId " +
                       "WHERE sc.total_balance != 0 AND sc.contract_status = 'Active' " +
                       "ORDER BY l.l_lastname"
                    );
            closeConn();
        }
    }
}
