﻿using System;
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
    public class CustomerController
    {
        private DataAccess.DataAccess _dataAccess;
        private CustomerMapper _customerMapper;
        private List<Customer> _customers;
        public CustomerController()
        {
            string constr = GlobalData.connectionString;

            _dataAccess = new DataAccess.DataAccess(constr);
            _customerMapper = new CustomerMapper(_dataAccess);
            //GetCustomers();
        }
        /*public void GetCustomers()
        {
            _customers = _customerMapper.GetAllCustomersList();
        }*/
    }
}
