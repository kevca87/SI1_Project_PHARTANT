using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using PHARTANT.Dal;
//using PHARTANT.DataAccess;

namespace PHARTANT.Model
{
    public class Customer
    {
        private CustomerMapper _costumerMapper;
        private DataAccess.DataAccess _dataAccess;

        public int nit { get; set; }
        public string name { get; set; }
        /*
         private int nit;
         private string name;
         public int getNit(){
            return nit
        }
         public string getName(){
            return name;
        }
         */
    }
}
