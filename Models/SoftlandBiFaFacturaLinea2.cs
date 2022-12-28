using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class SoftlandBiFaFacturaLinea2
    {
        public string ArticuloCodigo { get; set; } = null!;
        public string ArticuloDescripcion { get; set; } = null!;
        public string? ArticuloClasificacion1 { get; set; }
        public string? ArticuloClasificacion2 { get; set; }
        public string? ArticuloClasificacion3 { get; set; }
        public string? ArticuloClasificacion4 { get; set; }
        public string? ArticuloClasificacion5 { get; set; }
        public string? ArticuloClasificacion6 { get; set; }
        public string ArticuloClaseAbc { get; set; } = null!;
        public string Pais { get; set; } = null!;
        public string Zona { get; set; } = null!;
        public string Ruta { get; set; } = null!;
        public string Bodega { get; set; } = null!;
        public string CategoriaCliente { get; set; } = null!;
        public string Cliente { get; set; } = null!;
        public string? ClienteRubro1 { get; set; }
        public string? ClienteRubro2 { get; set; }
        public string? ClienteRubro3 { get; set; }
        public string? ClienteRubro4 { get; set; }
        public string? ClienteRubro5 { get; set; }
        public string Vendedor { get; set; } = null!;
        public string Cobrador { get; set; } = null!;
        public string? MonedaFactura { get; set; }
        public string TipoFactura { get; set; } = null!;
        public string Factura { get; set; } = null!;
        public string? Pedido { get; set; }
        public string Anulada { get; set; } = null!;
        public DateTime FechaFactura { get; set; }
        public int? SemanaFactura { get; set; }
        public int? MesFactura { get; set; }
        public int? TrimestreFactura { get; set; }
        public int? AnoFactura { get; set; }
        public decimal? Cantidad { get; set; }
        public decimal? Impuesto1Local { get; set; }
        public decimal? Impuesto1Dolar { get; set; }
        public decimal? Impuesto2Local { get; set; }
        public decimal? Impuesto2Dolar { get; set; }
        public decimal? TotalImpuestoLocal { get; set; }
        public decimal? TotalImpuestoDolar { get; set; }
        public decimal? DescuentoLineaLocal { get; set; }
        public decimal? DescuentoLineaDolar { get; set; }
        public decimal? DescuentoGeneralLocal { get; set; }
        public decimal? DescuentoGeneralDolar { get; set; }
        public decimal? DescuentoTotalLocal { get; set; }
        public decimal? DescuentoTotalDolar { get; set; }
        public decimal? DescuentoVolumenLocal { get; set; }
        public decimal? DescuentoVolumenDolar { get; set; }
        public decimal? PrecioTotalLocal { get; set; }
        public decimal? PrecioTotalDolar { get; set; }
        public decimal? VentaNetaLocal { get; set; }
        public decimal? VentaNetaDolar { get; set; }
        public decimal? CostoTotalLocal { get; set; }
        public decimal? CostoTotalDolar { get; set; }
        public decimal? UtilidadLocal { get; set; }
        public decimal? UtilidadDolar { get; set; }
        public decimal CantidadDevuelta { get; set; }
        public decimal? PrecioTotalLocalDevuelto { get; set; }
        public decimal? PrecioTotalDolarDevuelto { get; set; }
        public decimal CantidadBruta { get; set; }
        public decimal? PrecioTotalLocalBruto { get; set; }
        public decimal? PrecioTotalDolarBruto { get; set; }
        public decimal TipoCambio { get; set; }
    }
}
