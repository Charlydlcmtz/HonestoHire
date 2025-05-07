using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Usuario
    {
        public Guid Id { get; set; }
        public string Nombre { get; set; }
        public string ApellidoP { get; set; }
        public string ApellidoM { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }
        public string PasswordHash { get; set; }
        public Rol Rol { get; set; }
        public DateTime FechaRegistro { get; set; }
    }
}
