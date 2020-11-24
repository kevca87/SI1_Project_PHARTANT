using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PHARTANT.Dal;
using System.Data;
//using PHARTANT.Global;
//using PHARTANT.DataAccess;

namespace PHARTANT.Model
{
    public class Sale
    {
        private SaleMapper _saleMapper;
        private DataAccess.DataAccess _dataAccess;
        
        public int id_sale { get; set; }
        //public DateTime reservation_start_date{ get; set; }
        public double unit_price_sale { get; set; }
        public int quantity_product { get; set; }
        public int concrete_sale { get; set; }
        public DateTime sale_date_completed { get; set; }

        public Sale(SaleMapper mapper, DataAccess.DataAccess dac)
        {
            _saleMapper = mapper;
            _dataAccess = dac;
        }
        public Sale(SaleMapper mapper, DataAccess.DataAccess dac, int id_sale, double unit_price, int quantity, int concrete) : this(mapper, dac)
        {
            this.id_sale = id_sale;
           // reservation_start_date = reservation_start;
            unit_price_sale = unit_price;
            quantity_product = quantity;
            concrete_sale = concrete;
           // sale_date_completed = sale_date;
        }
        public Sale(SaleMapper mapper, DataAccess.DataAccess dac, int id_sale, double unit_price, int quantity, int concrete, DateTime sale_date) : this(mapper, dac)
        {
            this.id_sale = id_sale;
            //reservation_start_date = reservation_start;
            unit_price_sale = unit_price;
            quantity_product = quantity;
            concrete_sale = concrete;
            sale_date_completed = sale_date;
        }
    }
}
