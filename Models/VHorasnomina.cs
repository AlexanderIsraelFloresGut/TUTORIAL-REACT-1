using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class VHorasnomina
    {
        public string Empleado { get; set; } = null!;
        public string Concepto { get; set; } = null!;
        public string? Descripcion { get; set; }
        public string Nomina { get; set; } = null!;
        public short NumeroNomina { get; set; }
        public decimal Total { get; set; }
    }
}
