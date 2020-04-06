using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities
{
    public class CategoryEntity
    {
        [Key]
        [StringLength(100)]        
        public string categoryId { get; set; }
        [Required]
        public string categoryName { get; set; }

        /// <summary>
        ///   Relación con los productos
        /// </summary>
        public ICollection<ProductEntity> Products { get; set; }
    }
}
