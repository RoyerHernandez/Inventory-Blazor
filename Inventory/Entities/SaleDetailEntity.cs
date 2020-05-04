using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class SaleDetailEntity
    {
        public string saleId { get; set; }
        public int saleQuantity { get; set; }
        public string productId { get; set; }
        public ProductEntity unitPrice { get; set; }

    }
}
