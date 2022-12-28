using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class CsEmpleadoHorario
    {
        public string Horario { get; set; } = null!;
        public string Empleado { get; set; } = null!;
        public DateTime FechaAsignacion { get; set; }

        public virtual Empleado1 EmpleadoNavigation { get; set; } = null!;
        public virtual CsHorario HorarioNavigation { get; set; } = null!;
    }
}
