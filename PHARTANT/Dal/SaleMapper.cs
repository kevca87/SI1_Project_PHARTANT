using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using PHARTANT.Model;
using System.Data.OleDb;

namespace PHARTANT.Dal
{
    public class SaleMapper
    {
        private DataAccess.DataAccess _dataAccess;

        private DataAccess.DataAccess DataAccess
        {
            get { return _dataAccess; }
        }
        public SaleMapper(DataAccess.DataAccess da)
        {
            _dataAccess = da;
        }
        
        public List<Sale> GetAllSalesList()
        {
            string sqlSentence;

            List<Sale> list = new List<Sale>();

            sqlSentence = "SELECT * FROM Sale WHERE reservation_start_date<>NULL and sale_date_completed<>NULL";

            if (DataAccess.Open())
            {
                DataTable dt = DataAccess.GetDataTable(sqlSentence);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DataRow dr = dt.Rows[i];
                    int id_sale = Convert.ToInt32(dr["id_sale"]);
                   // DateTime reservation_start_date = Convert.ToDateTime(dr["reservation_start_date"]);
                    double unit_price_sale = Convert.ToDouble(dr["unit_price_sale"]);
                    int quantity_product = Convert.ToInt32(dr["concrete_sale"]);
                    int concrete_sale = Convert.ToInt32(dr["concrete_sale"]);
                    DateTime sale_date_completed = Convert.ToDateTime(dr["sale_date_completed"]);
                    //list.Add(new Sale(this, DataAccess, id_sale, unit_price_sale, quantity_product, concrete_sale));
                     list.Add(new Sale(this, DataAccess,id_sale, unit_price_sale, quantity_product, concrete_sale, sale_date_completed));
                }
                DataAccess.Close();
            }
            return list;
        }

        public List<Sale> GetAllReservationList()
        {
            string sqlSentence;

            List<Sale> list = new List<Sale>();

            sqlSentence = "SELECT * FROM Sale WHERE reservation_start_date=NULL";

            if (DataAccess.Open())
            {
                DataTable dt = DataAccess.GetDataTable(sqlSentence);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DataRow dr = dt.Rows[i];
                    int id_sale = Convert.ToInt32(dr["id_sale"]);
                    DateTime reservation_start_date = Convert.ToDateTime(dr["reservation_start_date"]);
                    double unit_price_sale = Convert.ToDouble(dr["unit_price_sale"]);
                    int quantity_product = Convert.ToInt32(dr["concrete_sale"]);
                    int concrete_sale = Convert.ToInt32(dr["concrete_sale"]);
                    //if()
                    DateTime sale_date_completed = Convert.ToDateTime(dr["sale_date_completed"]);
                    //list.Add(new Sale(this, DataAccess, id_sale, unit_price_sale, quantity_product, concrete_sale));
                    list.Add(new Sale(this, DataAccess, id_sale, unit_price_sale, quantity_product, concrete_sale, sale_date_completed));
                }
                DataAccess.Close();
            }
            return list;
        }

    }
}