using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class VMayorDivG2
    {
        public string Asiento { get; set; } = null!;
        public int Consecutivo { get; set; }
        public string CuentaContable { get; set; } = null!;
        public string DescripcionCuenta { get; set; } = null!;
        public string? Nit { get; set; }
        public string RazonSocial { get; set; } = null!;
        public DateTime Fecha { get; set; }
        public decimal? DebitoLocal { get; set; }
        public decimal? CreditoLocal { get; set; }
        public decimal? DebitoDolar { get; set; }
        public decimal? CreditoDolar { get; set; }
        public decimal? BaseDolar { get; set; }
        public decimal? BaseLocal { get; set; }
        public string SaldoNormal { get; set; } = null!;
        public string? Pais { get; set; }
        public string? DivGeo1 { get; set; }
        public string? DivGeo2 { get; set; }
        public string? Ubicacion { get; set; }
        public string Contabilidad { get; set; } = null!;
    }
}
