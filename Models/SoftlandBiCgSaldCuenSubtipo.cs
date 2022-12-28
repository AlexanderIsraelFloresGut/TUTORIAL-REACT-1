using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class SoftlandBiCgSaldCuenSubtipo
    {
        public string DescripCentroCosto { get; set; } = null!;
        public string DescripCuentaContable { get; set; } = null!;
        public string CodigoCentroCosto { get; set; } = null!;
        public string? CodigoCuentaContable { get; set; }
        public string SaldoNormal { get; set; } = null!;
        public string? TipoCuenta { get; set; }
        public string? SubtipoCuenta { get; set; }
        public string? AñoFiscal { get; set; }
        public int? TrimerstrFiscal { get; set; }
        public int? Ano { get; set; }
        public int? Trimestre { get; set; }
        public string? Mes { get; set; }
        public DateTime Fecha { get; set; }
        public decimal? MovimientoLocal { get; set; }
        public decimal? MovimientoDolar { get; set; }
        public decimal? SaldoFiscalLocal { get; set; }
        public decimal? SaldoFiscalDolar { get; set; }
        public decimal? SaldoCorporativoLocal { get; set; }
        public decimal? SaldoCorporativoDolar { get; set; }
        public decimal DebitoFiscalLlocal { get; set; }
        public decimal DebitoFiscalDolar { get; set; }
        public decimal DebitoCorporativoLocal { get; set; }
        public decimal DebitoCorporativoDolar { get; set; }
        public decimal CreditoFiscalLocal { get; set; }
        public decimal CreditoFiscalDolar { get; set; }
        public decimal CreditCorpLoc { get; set; }
        public decimal CreditCorpDol { get; set; }
        public decimal? SaldoIniFiscLoc { get; set; }
        public decimal? SaldoIniFiscDol { get; set; }
    }
}
