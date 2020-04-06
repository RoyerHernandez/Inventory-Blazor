using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities
{
    public class WarehouseEntity
    {
        [Key]
        [StringLength(100)]
        [Required]
        public string warehouseId { get; set; }
        [Required]
        public string warehouseName { get; set; }
        public string warehouseAddress { get; set; }
        /// <summary>
        /// Realación con los productos
        /// </summary>
        public ICollection<ProductEntity> Products { get; set; }
        /// <summary>
        /// Realción con las bodegas
        /// </summary>
        public ICollection<WarehouseEntity> Warehouses { get; set; }
    }
}
