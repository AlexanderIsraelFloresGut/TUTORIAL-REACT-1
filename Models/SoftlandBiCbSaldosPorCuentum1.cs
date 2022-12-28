using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class SoftlandBiCbSaldosPorCuentum1
    {
        public string CuentaBancaria { get; set; } = null!;
        public string NombreCuentaBancaria { get; set; } = null!;
        public string MonedaCuenta { get; set; } = null!;
        public string CuentaActiva { get; set; } = null!;
        public string EntidadFinanciera { get; set; } = null!;
        public string DescripcionEntidadFinanciera { get; set; } = null!;
        public string PermiteSobregiro { get; set; } = null!;
        public decimal LimiteSobregiro { get; set; }
        public string? CentroCosto { get; set; }
        public string? CuentaContable { get; set; }
        public decimal PosicionDeCaja { get; set; }
        public decimal SaldoEnBancos { get; set; }
        public decimal SaldoEnLibros { get; set; }
    }
}
