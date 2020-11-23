using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using PHARTANT.Dal;
using PHARTANT.Model;
using PHARTANT.Global;

namespace PHARTANT.Mapper
{
    public class SaleController
    {
        private DataAccess.DataAccess _dataAccess;
        private SaleMapper _saleMapper;
        private List<Sale> _sales;
        public SaleController()
        {
            string constr = GlobalData.connectionString;

            _dataAccess = new DataAccess.DataAccess(constr);
            _saleMapper = new SaleMapper(_dataAccess);
            //GetSales();
        }
        /*public void GetSales()
        {
            _sales = _saleMapper.GetAllSalesList();
        }*/
    }

}
