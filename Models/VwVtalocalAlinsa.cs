using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class VwVtalocalAlinsa
    {
        public int? Year { get; set; }
        public int? Mes { get; set; }
        public string Cliente { get; set; } = null!;
        public string CategoriaCliente { get; set; } = null!;
        public string ArticuloCodigo { get; set; } = null!;
        public string ArticuloDescripcion { get; set; } = null!;
        public string? ArticuloClasificacion1 { get; set; }
        public string? ArticuloClasificacion2 { get; set; }
        public string Cobrador { get; set; } = null!;
        public string Factura { get; set; } = null!;
        public DateTime FechaFactura { get; set; }
        public decimal? Cantidad { get; set; }
        public decimal? Impuesto1Dolar { get; set; }
        public decimal? DescuentoLineaDolar { get; set; }
        public decimal? PrecioTotalLocal { get; set; }
        public decimal? PrecioTotalDolar { get; set; }
        public decimal? PrecioTotalDolarBruto { get; set; }
    }
}
