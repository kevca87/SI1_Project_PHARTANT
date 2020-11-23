using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PHARTANT.Dal;
using PHARTANT.Model;
using PHARTANT.Global;

namespace PHARTANT.Controller
{
    public class ProductController
    {
        private DataAccess.DataAccess _dataAccess;
        private ProductMapper _productMapper;
        private List<Product> _products;

        private ProductMapper Mapper
        {
            get { return _productMapper; }
        }
        public ProductController()
        {
            string constr = GlobalData.connectionString;

            _dataAccess = new DataAccess.DataAccess(constr);
            _productMapper = new ProductMapper(_dataAccess);

            //GetAirports();
        }
    }
}