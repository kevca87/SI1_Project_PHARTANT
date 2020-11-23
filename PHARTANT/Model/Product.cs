using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PHARTANT.Dal;

namespace PHARTANT.Model
{
    class Product
    {
        private ProductMapper _mapper;
        private DataAccess.DataAccess _dataAccess;

        public int id_product { get; set; }
        public string trade_name { get; set; }
        public string generic_name { get; set; }
        public string trade_mark { get; set; }
        public float unit_price { get; set; }
        public string presentation_type { get; set; }
        public int quantity_box { get; set; }
        public float box_price { get; set; }

        internal Product()
        {
            id_product = 0;
            trade_name = "";
            generic_name = "";
            trade_mark = "";
            unit_price = 0;
            presentation_type = "";
            quantity_box = 0;
            box_price = 0;
        }

        public Product(ProductMapper mapper, DataAccess.DataAccess dac)
        {
            _mapper = mapper;
            _dataAccess = dac;
        }

        public Product(ProductMapper mapper, DataAccess.DataAccess dac, int id_product, string trade_name, string generic_name,string trade_mark,float unit_price,string presentation_type,int quantity_box, float box_price) : this(mapper, dac)
        {
            this.id_product = id_product;
        }
    }
}
