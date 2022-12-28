using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class BarcoActividad
    {
        public int Id { get; set; }
        public int Barco { get; set; }
        public int Actividad { get; set; }
        public DateTime FechaActividad { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string HostName { get; set; } = null!;
        public DateTime FechaActualizacion { get; set; }
        public string HostNameActualizacion { get; set; } = null!;

        public virtual Actividad ActividadNavigation { get; set; } = null!;
        public virtual Barco BarcoNavigation { get; set; } = null!;
    }
}
