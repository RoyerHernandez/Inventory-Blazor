using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities
{
    public class ProductEntity
    {
        [Key]
        [StringLength(100)]
        [Required]
        public string productId { get; set; }
        [Required]
        public string productName { get; set; }
        public string productDesciption { get; set; }
        public decimal totalQuantity { get; set; }
        /// <summary>
        /// RElación con las categorias
        /// </summary>
        [Required]
        public string categoryId { get; set; }
        public CategoryEntity Category { get; set; }
        /// <summary>
        /// Relación con el almacenamiento
        /// </summary>
        public ICollection<StorageEntity> Storages { get; set; }

    }
}
