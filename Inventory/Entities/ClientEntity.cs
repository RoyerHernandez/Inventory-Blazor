using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities
{
    public class ClientEntity
    {
        [Key]
        [MaxLength(12)]
        public int clientId { get; set; }
        [MaxLength(50)]
        [Required(ErrorMessage = "Se requiere nombre del cliente")]
        public string clientName { get; set; }
        [MaxLength(50)]
        [Required(ErrorMessage = "Se requiere apellido del cliente")]
        public string clientLastName { get; set; }
        [Required(ErrorMessage = "Se requiere dirección del cliente")]
        public string clientAddres { get; set; }
        [MaxLength(10)]
        [Required(ErrorMessage = "Se requiere numero telefonico del cliente")]
        public int numberPhone { get; set; }
        [EmailAddress(ErrorMessage ="Dirección de correo eléctronico no valida")]
        [Required(ErrorMessage = "Se requiere dirección de correo electronico del cliente")]
        public string eMail { get; set; }
    }
}
