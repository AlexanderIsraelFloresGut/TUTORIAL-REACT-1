using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class DetalleFacturaRetencion2
    {
        public string? Retencion { get; set; }
        public string? Factura { get; set; }
        public string? TipoDoc { get; set; }
        public int? FacturaLinea { get; set; }
        public string? Articulo { get; set; }
        public decimal? BaseRetencion { get; set; }
        public decimal? MontoRetencion { get; set; }
    }
}
