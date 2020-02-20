using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StallManagementSystem
{
    class ambulantClass : Connection
    {
        public void getAmbulantSales()
        {
            sqlQuery(
                       "SELECT l.l_lastname, l.l_firstname, l.l_middlename, a.amount, a.date_paid FROM ambulant_sales a " +
                       "INNER JOIN lessees_tbl l ON l.lessee_id = a.lesseeId"
                    );
            closeConn();
        }
        
        public void searchAmbulantPayments(string searchedName)
        {
            sqlQuery(
                       "SELECT l.l_lastname, l.l_firstname, l.l_middlename, a.amount, a.date_paid FROM ambulant_sales a " +
                       "INNER JOIN lessees_tbl l ON l.lessee_id = a.lesseeId "+
                       "WHERE CONCAT(l_lastname,' ', l_firstname,' ', l_middlename) LIKE @searched"
                    );
            _cmd.Parameters.AddWithValue("@searched", "%" + searchedName + "%");
            closeConn();
        }

        public void getAmbulants()
        {
            sqlQuery("SELECT lessee_id, l_lastname, l_firstname, l_middlename FROM lessees_tbl WHERE lessee_type = 'ambulant'");
            closeConn();
        }

        public void searchAmbulants(string searchedName)
        {
            sqlQuery("SELECT lessee_id, l_lastname, l_firstname, l_middlename FROM lessees_tbl WHERE lessee_type = 'ambulant' AND CONCAT(l_lastname,' ', l_firstname,' ', l_middlename) LIKE @searched");
            _cmd.Parameters.AddWithValue("@searched", "%" + searchedName + "%");
            closeConn();
        }
    }
}
