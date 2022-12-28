using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class SoftlandBiCcRecibo1
    {
        public string TipoDebito { get; set; } = null!;
        public string Debito { get; set; } = null!;
        public string Documento { get; set; } = null!;
        public string CodigoCliente { get; set; } = null!;
        public string? NombreCliente { get; set; }
        public string? Vendedor { get; set; }
        public string? Cobrador { get; set; }
        public int? AnoFechaCredito { get; set; }
        public int? TrimestreFechaCredito { get; set; }
        public int? MesFechaCredito { get; set; }
        public DateTime FechaCredito { get; set; }
        public int? DiasTardoCancelar { get; set; }
        public int? DiasVencido { get; set; }
        public int? CondicionPago { get; set; }
        public string Aplicacion { get; set; } = null!;
        public decimal AbonoRealizado { get; set; }
        public decimal MontoLocalCredito { get; set; }
        public decimal MontoDolarCredito { get; set; }
        public decimal SaldoLocalCredito { get; set; }
        public decimal SaldoDolarCredito { get; set; }
        public decimal MontoLocalDebito { get; set; }
        public decimal MontoDolarDebito { get; set; }
    }
}
