using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PHARTANT.Dal;
using PHARTANT.Model;
using PHARTANT.Global;

namespace PHARTANT.Controller
{
    public class ConceptController
    {
        private DataAccess.DataAccess _dataAccess;
        private ConceptMapper _conceptMapper;
        private List<Concept> _concepts;

        private ConceptMapper Mapper
        {
            get { return _conceptMapper; }
        }
        public ConceptController()
        {
            string constr = GlobalData.connectionString;


            _dataAccess = new DataAccess.DataAccess(constr);
            _conceptMapper = new ConceptMapper(_dataAccess);

        }
    }
}