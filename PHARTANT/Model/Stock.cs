using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PHARTANT.Dal;

namespace PHARTANT.Model
{
    class Stock
    {
        private StockMapper _mapper;
        private DataAccess.DataAccess _dataAccess;

        public int id_stock { get; set; }
        public int id_product { get; set; }
        public DateTime expiration_date { get; set; }
        public string name_provider { get; set; }
        public int quantity_product { get; set; }
        
        internal Stock()
        {
            id_stock = 0;
            id_product = 0;
            expiration_date = new DateTime();
            name_provider = "";
            quantity_product = 0;
        }

        public Stock(StockMapper mapper, DataAccess.DataAccess dac)
        {
            _mapper = mapper;
            _dataAccess = dac;
        }

        public Stock(StockMapper mapper, DataAccess.DataAccess dac, int id_stock, int id_product, DateTime expiration_date, string name_provider, int quantity_product) : this(mapper, dac)
        {
            this.id_stock = id_stock;
            this.id_product = id_product;
            this.expiration_date = expiration_date;
            this.name_provider = name_provider;
            this.quantity_product = quantity_product;
        }
    }
}
