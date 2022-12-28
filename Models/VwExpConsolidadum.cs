using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class VwExpConsolidadum
    {
        public int? Año { get; set; }
        public int? Mes { get; set; }
        public string Factura { get; set; } = null!;
        public DateTime FechaDespacho { get; set; }
        public string Cliente { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public string Articulo { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public string Bodega { get; set; } = null!;
        public decimal Cantidad { get; set; }
        public decimal CantidadAceptada { get; set; }
        public decimal PrecioUnitario { get; set; }
        public decimal? Total { get; set; }
        public decimal TotalUnidades { get; set; }
        public string Empresa { get; set; } = null!;
        public string Anulada { get; set; } = null!;
        public DateTime FechaFactura { get; set; }
        public string? Consecutivo { get; set; }
        public decimal TotalImpuesto1 { get; set; }
        public decimal TipoCambio { get; set; }
        public string Moneda { get; set; } = null!;
        public decimal TotalFactura { get; set; }
        public decimal PrecioTotal { get; set; }
    }
}
