using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities
{
    public class InOutEntity
    {
        [Key]
        [StringLength(100)]
        public string inOutsID { get; set; }
        [Required]
        public DateTime InOutDate { get; set; }
        [Required]
        public int Quality { get; set; }
        [Required]
        public bool IsInput { get; set; }
        /// <summary>
        /// Relación con el almacenamiento
        /// </summary>
        public string storageId { get; set; }
        public StorageEntity Storage { get; set; }
    }
}
