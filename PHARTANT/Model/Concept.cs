using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PHARTANT.Dal;

namespace PHARTANT.Model
{
    class Concept
    {
        private ConceptMapper _mapper;
        private DataAccess.DataAccess _dataAccess;

        public int id_concept { get; set; }
        public int id_transaction { get; set; }
        public int id_product { get; set; }
        public int quantity { get; set; }
        
        internal Concept()
        {
            id_concept = 0;
            id_transaction = 0;
            id_product = 0;
            quantity = 0;
        }

        public Concept(ConceptMapper mapper, DataAccess.DataAccess dac)
        {
            _mapper = mapper;
            _dataAccess = dac;
        }

        public Concept(ConceptMapper mapper, DataAccess.DataAccess dac, int id_concept,int id_transaction, int id_product, int quantity) : this(mapper, dac)
        {
            this.id_concept = id_concept;
            this.id_transaction = id_transaction;
            this.id_product = id_product;
            this.quantity = quantity;
        }
    }
}
