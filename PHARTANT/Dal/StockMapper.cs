﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using PHARTANT.Models;
using System.Data.OleDb;

namespace PHARTANT.Dal
{
    public class StockMapper
    {
        private DataAccess.DataAccess _dataAccess;
        private DataAccess.DataAccess DataAccess
        {
            get { return _dataAccess; }
        }
        public StockMapper(DataAccess.DataAccess da)
        {
            _dataAccess = da;
        }
    }
}