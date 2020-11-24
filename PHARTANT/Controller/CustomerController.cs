using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using PHARTANT.Dal;
using PHARTANT.Model;

namespace PHARTANT.Controller
{
    public class CustomerController
    {
        private DataAccess.DataAccess _dataAccess;
        private CustomerMapper _customerMapper;
        private List<Customer> _customers;
    }
}
