using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class SoftlandBiFacturalinea1
    {
        public string Facturacompuesta { get; set; } = null!;
        public short Linea { get; set; }
        public string Bodega { get; set; } = null!;
        public string Articulo { get; set; } = null!;
        public decimal? Cantidad { get; set; }
        public decimal Cantidaddevuelta { get; set; }
        public decimal? Ventabrutalocal { get; set; }
        public decimal? Impuesto1local { get; set; }
        public decimal? Impuesto2local { get; set; }
        public decimal? Descuentolinealocal { get; set; }
        public decimal? Descuentogenerallocal { get; set; }
        public decimal? Costolocal { get; set; }
        public decimal? Descuentovolumenlocal { get; set; }
        public decimal? Montodevolucioneslocal { get; set; }
        public decimal? Ventabrutadolar { get; set; }
        public decimal? Impuesto1dolar { get; set; }
        public decimal? Impuesto2dolar { get; set; }
        public decimal? Descuentolineadolar { get; set; }
        public decimal? Descuentogeneraldolar { get; set; }
        public decimal? Costodolar { get; set; }
        public decimal? Descuentovolumendolar { get; set; }
        public decimal? Montodevolucionesdolar { get; set; }
        public string MonedaFactura { get; set; } = null!;
        public decimal TipoCambio { get; set; }
    }
}
