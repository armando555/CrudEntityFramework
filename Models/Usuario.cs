using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CrudEntityFramework.Models
{
    public class Usuario
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="El nombre es obligatorio")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "El telefono es obligatorio")]
        [Display(Name ="Teléfono")]
        public string Telefono { get; set; }
        [Required(ErrorMessage = "El celular es obligatorio")]
        [Display(Name = "Celular")]
        public string celular{ get; set; }
        [Required(ErrorMessage = "El e-mail es obligatorio")]
        public string Email { get; set; }

    }
}
