using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Postulacion
    {
        public Guid Id { get; set; }
        public Guid VacanteId { get; set; }
        public Vacante Vacante { get; set; }
        public Guid UsuarioId { get; set; }
        //public Usuario Usuario { get; set; }
        public string Estatus { get; set; } // Pendiente, Aceptada, Rechazada
        public DateTime FechaPostulacion { get; set; }
    }
}
