using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;


namespace PHARTANT.DataAccess
{
    public class DataAccess
    {

        private OleDbConnection _connection;
        private string _connectionString;
        public DataAccess(string connectionString)
        {
            _connectionString = connectionString;
        }

        public string ConnectionString
        {
            get { return _connectionString; }
            set { _connectionString = value; }
        }

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
