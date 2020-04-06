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
        [Required]
        public string storageId { get; set; }
        [Required]
        public string storageName { get; set; }
        public Decimal partialQuantity { get; set; }
        /// <summary>
        /// Rlación con las Bodegas
        /// </summary>
        [Required]
        public string warehouseId { get; set; }
        public WarehouseEntity warehouse { get; set; }
        /// <summary>
        /// Relación con los productos
        /// </summary>
        [Required]
        public string productId { get; set; }
        public ProductEntity Product { get; set; }
        /// <summary>
        /// RElación con las salidas y entradas
        /// </summary>
        public ICollection<InOutEntity> InOuts { get; set; }

    }
}
