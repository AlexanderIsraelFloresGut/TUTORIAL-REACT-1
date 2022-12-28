using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class VLibrovacacion2
    {
        public string Empleado { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public string EstadoEmpleado { get; set; } = null!;
        public string Activo { get; set; } = null!;
        public DateTime FechaIngreso { get; set; }
        public string Departamento { get; set; } = null!;
        public string Puesto { get; set; } = null!;
        public string CentroCosto { get; set; } = null!;
        public string? Nit { get; set; }
        public decimal VacsPendientes { get; set; }
        public DateTime VacsUltCalculo { get; set; }
        public decimal SalarioReferencia { get; set; }
    }
}
