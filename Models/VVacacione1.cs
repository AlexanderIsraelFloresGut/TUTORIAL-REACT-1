using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class VVacacione1
    {
        public string? Empleado { get; set; }
        public string? EstadoEmpleado { get; set; }
        public DateTime? FechaIngreso { get; set; }
        public decimal? VacsPendientes { get; set; }
        public string Nomina { get; set; } = null!;
        public short NumeroNomina { get; set; }
        public string Concepto { get; set; } = null!;
        public decimal Total { get; set; }
        public DateTime? Fecha { get; set; }
        public DateTime? FechaRige { get; set; }
        public DateTime? FechaVence { get; set; }
        public decimal? DiasAccion { get; set; }
    }
}
