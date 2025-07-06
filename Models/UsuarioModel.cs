using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeberSem6.Models
{
    public class UsuarioModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre de usuario está vacío")]
        public string Nombres { get; set; }

        public string Apellidos { get; set; }

        [Required(ErrorMessage = "La edad del usuario está vacía")]
        public int Edad { get; set; }

        public string Genero { get; set; }

        [Required(ErrorMessage = "El correo del usuario está vacío")]
        public string Correo { get; set; }

        [Required(ErrorMessage = "La dirección del usuario está vacía")]
        public string Direccion { get; set; }

        public string CodigoPostal { get; set; }
    }
}
