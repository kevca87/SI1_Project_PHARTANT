using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
<<<<<<< HEAD
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;

=======
using System.Data;
using System.Data.OleDb;


>>>>>>> 3135a15743959305d60231daa010675c3a4c9951
namespace PHARTANT.DataAccess
{
    public class DataAccess
    {
<<<<<<< HEAD
        private OleDbConnection _connection;
        private string _connectionString;

=======

        private OleDbConnection _connection;
        private string _connectionString;
>>>>>>> 3135a15743959305d60231daa010675c3a4c9951
        public DataAccess(string connectionString)
        {
            _connectionString = connectionString;
        }

        public string ConnectionString
        {
            get { return _connectionString; }
            set { _connectionString = value; }
        }
<<<<<<< HEAD
=======

>>>>>>> 3135a15743959305d60231daa010675c3a4c9951
        public Boolean Open()
        {
            try
            {
                if (string.IsNullOrEmpty(_connectionString))
                    return false;

                _connection = new OleDbConnection();
                _connection.ConnectionString = _connectionString;

                _connection.Open();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }

        }

        public Boolean Close()
        {
            try
            {
                if (_connection.State == ConnectionState.Open)
                    _connection.Close();
                return true;
            }
            catch //(Exception e)
            {
                return false;
            }

        }
<<<<<<< HEAD
=======

>>>>>>> 3135a15743959305d60231daa010675c3a4c9951
        public DataTable GetDataTable(string p_str_sql)
        {
            string strConn = ConnectionString;

            DataTable l_dt = new DataTable();
            OleDbDataAdapter sqlDa = new OleDbDataAdapter(p_str_sql, _connection);
            try
            {
                sqlDa.Fill(l_dt);
                return l_dt;
            }
            catch (Exception ex)
            {
                return null;
            }

        }


        public int ExecuteCommand(string str_sql, out string io_error)
        {
            OleDbCommand l_comando;

            try
            {
                l_comando = new OleDbCommand();
                l_comando.CommandText = str_sql;
                l_comando.Connection = _connection;
                io_error = "";
                return l_comando.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                io_error = e.Message;
                return 0;
            }
        }

        public int ExecuteCommand(OleDbCommand command, out string io_error)
        {
            try
            {
                command.Connection = _connection;
                io_error = "";
                return command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                io_error = e.Message;
                return 0;
            }
        }
    }
}
