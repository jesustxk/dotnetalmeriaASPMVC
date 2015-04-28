using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebPrueba.Models
{
    public class Persona
    {
        public int PersonaID { get; set; }

        [Required()]
        public string Nombre { get; set; }

        public string Apellidos { get; set; }

        [Required()]
        [Display(Name = "Dirección email")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
    }
}
