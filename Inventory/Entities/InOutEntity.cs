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
        [Required]
        public string inOutsID { get; set; }
        public DateTime InOutDate { get; set; }
        public string Quality { get; set; }
        /// <summary>
        /// Relación con el almacenamiento
        /// </summary>
        [Required]
        public string storageId { get; set; }
        public StorageEntity Storage { get; set; }
    }
}
