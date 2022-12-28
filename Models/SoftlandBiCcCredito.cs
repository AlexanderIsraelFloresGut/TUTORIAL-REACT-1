using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class SoftlandBiCcCredito
    {
        public string TipoDebito { get; set; } = null!;
        public string Debito { get; set; } = null!;
        public string Credito { get; set; } = null!;
        public string Cliente { get; set; } = null!;
        public string NombreCliente { get; set; } = null!;
        public string? Vendedor { get; set; }
        public string? NombreVendedor { get; set; }
        public string Cobrador { get; set; } = null!;
        public string NombreCobrador { get; set; } = null!;
        public DateTime FechaCredito { get; set; }
        public int? AnoFechaCredito { get; set; }
        public int? TrimestreFechaCredito { get; set; }
        public int? MesFechaCredito { get; set; }
        public int? DiasHastaCancelacion { get; set; }
        public int? DiasDespuesVencimiento { get; set; }
        public string CondicionPagoDebito { get; set; } = null!;
        public string AplicacionCredito { get; set; } = null!;
        public decimal Abono { get; set; }
        public decimal MontoLocalCredito { get; set; }
        public decimal MontoDolarCredito { get; set; }
        public decimal SaldoLocalCredito { get; set; }
        public decimal SaldoDolarCredito { get; set; }
        public decimal MontoLocalDebito { get; set; }
        public decimal MontoDolarDebito { get; set; }
    }
}
