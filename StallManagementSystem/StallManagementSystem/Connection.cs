using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace StallManagementSystem
{
    class Connection
    {
        protected string databaseName = "stall_market";
        protected string source = "localhost";
        protected string username = "root";
        protected string password = "";


        protected MySqlConnection _myConnection;
        protected MySqlCommand _cmd;
        protected MySqlDataAdapter _da;
        protected DataTable _dt;
        protected MySqlDataReader _myReader;
        public Connection()
        {
            try
            {
                _myConnection = new MySqlConnection("datasource = " + source + "; database = " + databaseName + "; port = 3306; Uid = " + username + "; password = " + password + "");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void sqlQuery(string query)
        {
            try
            {
                _myConnection.Open();
                _cmd = new MySqlCommand(query, _myConnection);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public DataTable QueryExe()
        {
            try
            {
                _da = new MySqlDataAdapter(_cmd);
                _dt = new DataTable();
                _da.Fill(_dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return _dt;
        }

        public void NonQueryExe()
        {
            try
            {
                _cmd.ExecuteNonQuery();
                closeConn();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public MySqlDataReader readerExe(string query)
        {
            MySqlDataReader myReader = null;
            try
            {
                _myConnection.Open();
                MySqlCommand cmd = new MySqlCommand(query, _myConnection);
                myReader = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return myReader;
        }

        public void closeConn()
        {
            _myConnection.Close();
        }

        public void openCon()
        {
            _myConnection.Open();
        }

        public DataSet datasetQuery(string table)
        {
            DataSet ds = null;
            try
            {
                _da = new MySqlDataAdapter(_cmd);
                ds = new DataSet();
                _da.Fill(ds, table);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            return ds;
        }
    }
}
