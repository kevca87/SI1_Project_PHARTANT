﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using PHARTANT.Model;
using System.Data.OleDb;

namespace PHARTANT.Dal
{
    public class CustomerMapper
    {
        private DataAccess.DataAccess _dataAccess;

        private DataAccess.DataAccess DataAccess
        {
            get { return _dataAccess; }
        }
        public CustomerMapper(DataAccess.DataAccess da)
        {
            _dataAccess = da;
        }

    }
}