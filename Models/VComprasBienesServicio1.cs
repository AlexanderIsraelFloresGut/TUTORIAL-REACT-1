using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class VComprasBienesServicio1
    {
        public string Cuentabanco { get; set; } = null!;
        public string Proveedor { get; set; } = null!;
        public string? RncCed { get; set; }
        public string? TipoId { get; set; }
        public string TipoDoc { get; set; } = null!;
        public int? SubtipoDoc { get; set; }
        public string? NumeroDoc { get; set; }
        public string Ncf { get; set; } = null!;
        public string Moneda { get; set; } = null!;
        public DateTime? FechaDoc { get; set; }
        public decimal? MontoTotal { get; set; }
        public decimal Saldo { get; set; }
        public decimal Tasa { get; set; }
        public decimal? Subtotal { get; set; }
        public decimal? Descuento { get; set; }
        public decimal? Impuesto1 { get; set; }
        public decimal? Impuesto2 { get; set; }
        public decimal? Rubro1 { get; set; }
        public decimal? Rubro2 { get; set; }
        public decimal Retencion { get; set; }
        public int ValeCh { get; set; }
        public int LineaVale { get; set; }
        public DateTime? FechaOrig { get; set; }
        public string Modulo { get; set; } = null!;
    }
}
