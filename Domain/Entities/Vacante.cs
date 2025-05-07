using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Vacante
    {
        public Guid Id { get; set; }
        public string titulo { get; set; }
        public string Descripcion { get; set; }
        public decimal SueldoMin { get; set; }
        public decimal SueldoMax { get; set; }
        public string Modalidad { get; set; } // Presencial, Híbrido, Remoto
        public string Ubicacion { get; set; } // Ciudad, Estado
        public string Idioma { get; set; }
        public string Requisitos { get; set; }
        public string Beneficios { get; set; }
        public DateTime FechaPublicacion { get; set; }
        public DateTime FechaLimite { get; set; }
        public bool Activa { get; set; }
        public Guid EmpresaId { get; set; }
        public Empresa Empresa { get; set; }
        public ICollection<Postulacion> Postulaciones { get; set; }
    }
}
