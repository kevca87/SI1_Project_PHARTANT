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
        private CustomerMapper _customerMapper;
        private DataAccess.DataAccess _dataAccess;

        public int nit { get; set; }
        public string name { get; set; }

        public Customer(CustomerMapper mapper, DataAccess.DataAccess dac)
        {
            _customerMapper = mapper;
            _dataAccess = dac;
        }
        public Customer(CustomerMapper mapper, DataAccess.DataAccess dac, int nit, string name) : this(mapper, dac)
        {
            this.nit=nit;
            this.name=name;
        }
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
