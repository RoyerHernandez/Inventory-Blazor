using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities
{
    public class StorageEntity
    {
        [Key]
        [StringLength(100)]
        public string storageId { get; set; }
        [Required]
        public int partialQuantity { get; set; }
        [Required]
        public DateTime LastUpdate { get; set; }
        /// <summary>
        /// Rlación con las Bodegas
        /// </summary>
        public string warehouseId { get; set; }
        public WarehouseEntity warehouse { get; set; }
        /// <summary>
        /// Relación con los productos
        /// </summary>
        public string productId { get; set; }
        public ProductEntity Product { get; set; }
        /// <summary>
        /// Relación con las salidas y entradas
        /// </summary>
        public ICollection<InOutEntity> InOuts { get; set; }

    }
}
