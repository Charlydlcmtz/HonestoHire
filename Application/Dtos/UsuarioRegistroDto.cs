using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dtos
{
    public class UsuarioRegistroDto
    {
        public string Username { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public string ApellidoP { get; set; } = null!;
        public string ApellidoM { get; set; } = null!;
        public string Telefono { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string ConfirmPassword { get; set; } = null!;

    }
}
