using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class SoftlandBiCgMovCuenMayor
    {
        public string CodigoCentroCosto { get; set; } = null!;
        public string CodigoCuentaContable { get; set; } = null!;
        public string DescripcionCuenta { get; set; } = null!;
        public string SaldoNormal { get; set; } = null!;
        public string? TipoCuenta { get; set; }
        public string? SubtipoCuenta { get; set; }
        public string Asiento { get; set; } = null!;
        public string Origen { get; set; } = null!;
        public string TipoAsiento { get; set; } = null!;
        public string? ClaseAsiento { get; set; }
        public string? AñoFiscal { get; set; }
        public int? AñoAsientoCreacion { get; set; }
        public string? MesAsientoCreacion { get; set; }
        public int? SemanaAsientoCreacion { get; set; }
        public DateTime Fecha { get; set; }
        public string Fuente { get; set; } = null!;
        public string Referencia { get; set; } = null!;
        public decimal DebitoLocal { get; set; }
        public decimal DebitoDolar { get; set; }
        public decimal CreditoLocal { get; set; }
        public decimal CreditoDolar { get; set; }
        public decimal? SaldoLocal { get; set; }
        public decimal? SaldoDolar { get; set; }
        public string Usuario { get; set; } = null!;
        public int? AñoAplicacion { get; set; }
        public string? MesAplicacion { get; set; }
        public DateTime FechaAplicacion { get; set; }
    }
}
