using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class AccionPersonal1
    {
        public int NumeroAccion { get; set; }
        public string Empleado { get; set; } = null!;
        public string? Departamento { get; set; }
        public string? Puesto { get; set; }
        public string? Plaza { get; set; }
        public string? CentroCosto { get; set; }
        public string? Nomina { get; set; }
        public string? RegimenVacacional { get; set; }
        public decimal? SalarioDiarioInt { get; set; }
        public string? EstadoEmpleado { get; set; }
        public decimal? SalarioPromedio { get; set; }
    }
}
