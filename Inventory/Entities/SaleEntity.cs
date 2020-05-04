using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class SaleEntity
    {
        public int saleId { get; set; }
        public DateTime saleDate { get; set; }
        public int IVA { get; set; }
        public int total { get; set; }
        public int clientId { get; set; }
        public ClientEntity clientName { get; set; }
    }
}
