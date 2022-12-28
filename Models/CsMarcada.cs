using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class CsMarcada
    {
        public int Marcada { get; set; }
        public string Empleado { get; set; } = null!;
        public DateTime FechaEntrada { get; set; }
        public DateTime FechaSalida { get; set; }

        public virtual Empleado1 EmpleadoNavigation { get; set; } = null!;
    }
}
