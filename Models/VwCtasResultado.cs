using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class VwCtasResultado
    {
        public string CuentaDescripcion { get; set; } = null!;
        public string CentroDescripcion { get; set; } = null!;
        public string? TipoCuenta { get; set; }
        public string? SubtipoCuenta { get; set; }
        public string? SaldoNormal { get; set; }
        public string Asiento { get; set; } = null!;
        public string CuentaContable { get; set; } = null!;
        public string CentroCosto { get; set; } = null!;
        public int? SemanaAsiento { get; set; }
        public int? MesAsiento { get; set; }
        public int? AnoAsiento { get; set; }
        public string Origen { get; set; } = null!;
        public string Fuente { get; set; } = null!;
        public string Referencia { get; set; } = null!;
        public decimal? DebitoLocal { get; set; }
        public decimal? CreditoLocal { get; set; }
        public decimal? DebitoDolar { get; set; }
        public decimal? CreditoDolar { get; set; }
        public string Usuario { get; set; } = null!;
        public int? MesAplicacion { get; set; }
        public string TipoAsiento { get; set; } = null!;
        public string Compania { get; set; } = null!;
    }
}
