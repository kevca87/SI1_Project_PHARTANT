using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using PHARTANT.Model;
using System.Data.OleDb;

namespace PHARTANT.Dal
{
    public class CustomerMapper
    {
        private DataAccess.DataAccess _dataAccess;

        private DataAccess.DataAccess DataAccess
        {
            get { return _dataAccess; }
        }
        public CustomerMapper(DataAccess.DataAccess da)
        {
            _dataAccess = da;
        }
        //Devuelve la lista con todos los clientes
        public List<Customer> GetAllCustomersList()
        {
            string sqlSentence;

            List<Customer> list = new List<Customer>();

            sqlSentence = "SELECT * FROM Customer";

            if (DataAccess.Open())
            {
                DataTable dt = DataAccess.GetDataTable(sqlSentence);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DataRow dr = dt.Rows[i];
                    int nit = Convert.ToInt32(dr["NIT"]);
                    string name = Convert.ToString(dr["name"]);
                    list.Add(new Customer(this, DataAccess, nit, name));
                }
                DataAccess.Close();
            }
            return list;
        }
    }
}