using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class CalculoAjustesNomi2
    {
        public int Consecutivo { get; set; }
        public string Empleado { get; set; } = null!;
        public string Nomina { get; set; } = null!;
        public int NumeroNomina { get; set; }
        public string Concepto { get; set; } = null!;
        public string CentroCosto { get; set; } = null!;
        public string? FormaAplicacion { get; set; }
        public decimal Cantidad { get; set; }
        public decimal Monto { get; set; }
        public decimal Total { get; set; }
        public string? Fase { get; set; }
        public string? Proyecto { get; set; }
        public string TipoRegistro { get; set; } = null!;
    }
}
