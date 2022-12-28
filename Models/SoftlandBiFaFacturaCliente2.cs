using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class SoftlandBiFaFacturaCliente2
    {
        public string Factura { get; set; } = null!;
        public string Cliente { get; set; } = null!;
        public string Contribuyente { get; set; } = null!;
        public string NombreCliente { get; set; } = null!;
        public string CategoriaCliente { get; set; } = null!;
        public string TipoDocumento { get; set; } = null!;
        public string? Pedido { get; set; }
        public decimal? TotalFacturaLocal { get; set; }
        public decimal? TotalFacturaDolar { get; set; }
        public decimal? DescuentoVolumenLocal { get; set; }
        public decimal? DescuentoVolumenDolar { get; set; }
        public decimal? TotalMercaderiaLocal { get; set; }
        public decimal? TotalMercaderiaDolar { get; set; }
        public decimal? TotalImpuesto1Local { get; set; }
        public decimal? TotalImpuesto1Dolar { get; set; }
        public decimal? TotalImpuesto2Local { get; set; }
        public decimal? TotalImpuesto2Dolar { get; set; }
        public int? AnoFecha { get; set; }
        public int? TrimestreFecha { get; set; }
        public int? MesFecha { get; set; }
        public DateTime? Fecha { get; set; }
        public string? DocumentoCxc { get; set; }
        public string? TipoDocumentoCc { get; set; }
        public string CondicionPago { get; set; } = null!;
        public string? Asiento { get; set; }
        public int? Transaccion { get; set; }
        public string Vendedor { get; set; } = null!;
        public string? ClaseAbc { get; set; }
        public string NombreVendedor { get; set; } = null!;
        public string? ClienteRubro1 { get; set; }
        public string? ClienteRubro2 { get; set; }
        public string? ClienteRubro3 { get; set; }
        public string? ClienteRubro4 { get; set; }
        public string? ClienteRubro5 { get; set; }
    }
}
