using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class VwListaembLocal
    {
        public int? AnoFactura { get; set; }
        public int? MesFactura { get; set; }
        public int? Dia { get; set; }
        public string Cliente { get; set; } = null!;
        public DateTime FechaFactura { get; set; }
        public string Factura { get; set; } = null!;
        public string ArticuloCodigo { get; set; } = null!;
        public string? ArticuloDelProv { get; set; }
        public decimal? Cantidad { get; set; }
        public decimal? VentaNetaLocal { get; set; }
        public decimal? VentaNetaDolar { get; set; }
    }
}
