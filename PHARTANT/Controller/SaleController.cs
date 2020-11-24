using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using PHARTANT.Dal;
using PHARTANT.Model;
using PHARTANT.Global;

namespace PHARTANT.Controller
{
    public class SaleController
    {
        private DataAccess.DataAccess _dataAccess;
        private SaleMapper _saleMapper;
        private List<Sale> _sales;
        private SaleMapper Mapper
        {
            get { return _saleMapper; }
        }

        public SaleController()
        {
            string constr = GlobalData.connectionString;

            _dataAccess = new DataAccess.DataAccess(constr);
            _saleMapper = new SaleMapper(_dataAccess);

            GetSales();
            //GetReservations();
        }

         public List<Sale> Sales
         {
             get { return _sales; }
         }
       
        public void GetSales()
        {
            _sales = Mapper.GetAllSalesList();
        }

        
        public List<Sale> Reservation
        {
            get { return _sales; }
        }
        public void GetReservations()
        {
            _sales = Mapper.GetAllReservationList();
        }
    }

   

}
