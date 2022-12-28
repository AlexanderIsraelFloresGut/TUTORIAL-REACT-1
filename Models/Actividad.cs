using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class Actividad
    {
        public Actividad()
        {
            BarcoActividads = new HashSet<BarcoActividad>();
        }

        public int Id { get; set; }
        public string Actividad1 { get; set; } = null!;
        public string? Descripcion { get; set; }
        public bool Activo { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string HostName { get; set; } = null!;

        public virtual ICollection<BarcoActividad> BarcoActividads { get; set; }
    }
}
