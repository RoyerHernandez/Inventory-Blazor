using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities
{
    public class OrderEntity
    {
        [Key]
        public string orderId { get; set; }
        [MaxLength(12)]
        public int clientId { get; set; }
        [MaxLength(150)]
        public string clientFullname { get; set; }
        public string productName { get; set; }
        public decimal unitPrice { get; set; }
        public decimal totalPrice { get; set; }
        public bool IsAdd { get; set; }
    }
}
