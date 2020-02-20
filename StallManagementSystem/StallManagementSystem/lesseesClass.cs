using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace StallManagementSystem
{
    class lesseesClass : Connection
    {
        LesseesUserControl _l;
        public lesseesClass()
        {

        }

        public lesseesClass(LesseesUserControl lf)
        {
            _l = lf;
        }

        public void searchLessee(string searchedName)
        {
            sqlQuery("SELECT * FROM lessees_tbl WHERE CONCAT(l_lastname,' ', l_firstname,' ', l_middlename) LIKE @searched");
            _cmd.Parameters.AddWithValue("@searched", "%" + searchedName + "%");
            closeConn();
        }

        public void filterLesseeType(string lesseetype)
        {
            sqlQuery("SELECT * FROM lessees_tbl WHERE lessee_type LIKE @lessee_type");
            _cmd.Parameters.AddWithValue("@lessee_type", "%"+ lesseetype + "%");
            closeConn();
        }

        public void getLessees()
        {
            sqlQuery("SELECT * FROM lessees_tbl");
            closeConn();
        }

        public void getIsAmbulantLessees()
        {
            sqlQuery("SELECT * FROM lessees_tbl WHERE lessee_type = 'ambulant'");
            closeConn();
        }

        public void getIsNotAmbulantLessees()
        {
            sqlQuery("SELECT * FROM lessees_tbl WHERE lessee_type = 'lessee'");
            closeConn();
        }

        public void saveLessee(Dictionary<string, string> ls)
        {
            sqlQuery(
                        "INSERT INTO lessees_tbl(l_firstname, l_middlename, l_lastname, lessee_type, gender, contact_no, email_add, address, emergency_contact) " +
                        "VALUES " +
                        "(@l_firstname, @l_middlename, @l_lastname, @lessee_type, @gender, @contact_no, @email_add, @address, @emergency_contact)"
                    );

            _cmd.Parameters.AddWithValue("@l_firstname", ls["l_firstname"]);
            _cmd.Parameters.AddWithValue("@l_middlename", ls["l_middlename"]);
            _cmd.Parameters.AddWithValue("@l_lastname", ls["l_lastname"]);
            _cmd.Parameters.AddWithValue("@lessee_type", ls["lessee_type"]);
            _cmd.Parameters.AddWithValue("@gender", ls["gender"]);
            _cmd.Parameters.AddWithValue("@contact_no", ls["contact_no"]);
            _cmd.Parameters.AddWithValue("@email_add", ls["email_add"]);
            _cmd.Parameters.AddWithValue("@address", ls["address"]);
            _cmd.Parameters.AddWithValue("@emergency_contact", ls["emergency_contact"]);
            int result = _cmd.ExecuteNonQuery();
            closeConn();

            if (result < 0)
            {
                MessageBox.Show("Failed!");
            }
            else
            {
                _l.clearInputs();
                _l.displayLessees();
                MessageBox.Show("Saved!");
            }
        }

        public void updateLessee(Dictionary<string, string> ls)
        {
            sqlQuery(
                        "UPDATE lessees_tbl SET l_firstname = @l_firstname, l_middlename = @l_middlename, l_lastname = @l_lastname, lessee_type = @lessee_type, " +
                        "gender = @gender, contact_no = @contact_no, email_add = @email_add, address = @address, emergency_contact = @emergency_contact "+
                        "WHERE lessee_id = @lessee_id"
                    );

            _cmd.Parameters.AddWithValue("@l_firstname", ls["l_firstname"]);
            _cmd.Parameters.AddWithValue("@l_middlename", ls["l_middlename"]);
            _cmd.Parameters.AddWithValue("@l_lastname", ls["l_lastname"]);
            _cmd.Parameters.AddWithValue("@lessee_type", ls["lessee_type"]);
            _cmd.Parameters.AddWithValue("@gender", ls["gender"]);
            _cmd.Parameters.AddWithValue("@contact_no", ls["contact_no"]);
            _cmd.Parameters.AddWithValue("@email_add", ls["email_add"]);
            _cmd.Parameters.AddWithValue("@address", ls["address"]);
            _cmd.Parameters.AddWithValue("@emergency_contact", ls["emergency_contact"]);
            _cmd.Parameters.AddWithValue("@lessee_id", ls["lessee_id"]);
            int result = _cmd.ExecuteNonQuery();
            closeConn();

            if (result < 0)
            {
                MessageBox.Show("Failed!");
            }
            else
            {
                _l.clearInputs();
                _l.displayLessees();
                MessageBox.Show("Updated!");
            }
        }
    }
}
