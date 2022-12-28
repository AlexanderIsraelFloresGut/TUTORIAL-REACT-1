using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class VwDeduccione1
    {
        public string Concepto { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public short NumeroNomina { get; set; }
        public string Nomina { get; set; } = null!;
        public decimal Total { get; set; }
        public string Empleado { get; set; } = null!;
        public decimal Cantidad { get; set; }
    }
}
