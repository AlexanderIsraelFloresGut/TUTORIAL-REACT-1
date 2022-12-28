using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class FiltroEmpleadoReporte2
    {
        public string Proceso { get; set; } = null!;
        public string Empleado { get; set; } = null!;

        public virtual Empleado2 EmpleadoNavigation { get; set; } = null!;
    }
}
