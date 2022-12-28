using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class SoftlandBiFaVentasCliente1
    {
        public string Factura { get; set; } = null!;
        public string Cliente { get; set; } = null!;
        public string Contribuyente { get; set; } = null!;
        public string NombreCliente { get; set; } = null!;
        public string? CategoriaCliente { get; set; }
        public string Pedido { get; set; } = null!;
        public decimal? TotalFacturaLocal { get; set; }
        public decimal? TotalFacturaSolar { get; set; }
        public decimal? DescuentoVolumenLocal { get; set; }
        public decimal? DescuentoVolumenSolar { get; set; }
        public decimal? TotalMercaderiaLocal { get; set; }
        public decimal? TotalMercaderiaSolar { get; set; }
        public decimal? TotalImpuesto1Local { get; set; }
        public decimal? TotalImpuesto1Solar { get; set; }
        public int? AnoFecha { get; set; }
        public int? TrimestreFecha { get; set; }
        public int? MesFecha { get; set; }
        public DateTime? Fecha { get; set; }
        public string? DocCreditoCxc { get; set; }
        public string TipoDocCxc { get; set; } = null!;
        public string CondicionPago { get; set; } = null!;
        public string AsientoDocumento { get; set; } = null!;
        public int? AuditTransInv { get; set; }
        public string Vendedor { get; set; } = null!;
        public string? ClaseAbc { get; set; }
        public string? NombreVendedor { get; set; }
        public string? Cobrador { get; set; }
        public string Rubro1Cli { get; set; } = null!;
        public string Rubro2Cli { get; set; } = null!;
        public string Rubro3Cli { get; set; } = null!;
        public string Rubro4Cli { get; set; } = null!;
        public string Rubro5Cli { get; set; } = null!;
    }
}
