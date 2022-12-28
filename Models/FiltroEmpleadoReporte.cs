using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class FiltroEmpleadoReporte
    {
        public string Proceso { get; set; } = null!;
        public string Empleado { get; set; } = null!;

        public virtual Empleado EmpleadoNavigation { get; set; } = null!;
    }
}
