using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class SoftlandBiCgSaldCuenContable1
    {
        public string CentroCostoCodigo { get; set; } = null!;
        public string CuentaContableCodigo { get; set; } = null!;
        public string CentroCosto { get; set; } = null!;
        public string CuentaContable { get; set; } = null!;
        public string TipoCuenta { get; set; } = null!;
        public string SubtipoCuenta { get; set; } = null!;
        public string SaldoNormal { get; set; } = null!;
        public string? FechaSaldo { get; set; }
        public int? MesSaldo { get; set; }
        public int? TrimestreSaldo { get; set; }
        public int? AnoSaldo { get; set; }
        public decimal? SaldoIniFiscalLocal { get; set; }
        public decimal DebitoFiscLocal { get; set; }
        public decimal CreditoFiscLocal { get; set; }
        public decimal SaldoFiscLocal { get; set; }
        public decimal? SaldoIniFiscalDolar { get; set; }
        public decimal CreditoFiscDolar { get; set; }
        public decimal SaldoFiscDolar { get; set; }
    }
}
