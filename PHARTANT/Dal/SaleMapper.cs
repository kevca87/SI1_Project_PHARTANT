using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;

namespace PHARTANT.Dal
{
    public class SaleMapper
    {
        private DataAccess.DataAccess _dataAccess;

        private DataAccess.DataAccess DataAccess
        {
            get { return _dataAccess; }
        }
        public SaleMapper(DataAccess.DataAccess da)
        {
            _dataAccess = da;
        }
    }
}