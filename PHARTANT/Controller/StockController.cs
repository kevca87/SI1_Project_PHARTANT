using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PHARTANT.Dal;
using PHARTANT.Model;
using PHARTANT.Global;

namespace PHARTANT.Controller
{
    public class StockController
    {
        private DataAccess.DataAccess _dataAccess;
        private StockMapper _stockMapper;
        private List<Stock> _stocks;

        private StockMapper Mapper
        {
            get { return _stockMapper; }
        }
        public StockController()
        {
            string constr = GlobalData.connectionString;


            _dataAccess = new DataAccess.DataAccess(constr);
            _stockMapper = new StockMapper(_dataAccess);

            //GetAirports();
        }
    }
}