using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Empresa
    {
        public Guid Id { get; set; }
        public string Nombre { get; set; }
        public string RazonSocial { get; set; }
        public string RFC { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public string Calle { get; set; }
        public string NumeroExterior { get; set; }
        public string Colonia { get; set; }
        public string Ciudad { get; set; }
        public string Estatus { get; set; }
        public string CodigoPostal { get; set; }
        public DateTime FechaRegistro { get; set; }
        public ICollection<Vacante> Vacantes { get; set; }
    }
}
