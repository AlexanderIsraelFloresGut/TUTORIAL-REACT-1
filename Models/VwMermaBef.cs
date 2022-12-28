using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class VwMermaBef
    {
        public int? Año { get; set; }
        public int? Mes { get; set; }
        public int? Dia { get; set; }
        public DateTime? FechaEmbarque { get; set; }
        public string Embarque { get; set; } = null!;
        public string OrdenCompra { get; set; } = null!;
        public short OrdenCompraLinea { get; set; }
        public string? Proveedor { get; set; }
        public string Nombre { get; set; } = null!;
        public string Articulo { get; set; } = null!;
        public string? Descripcion { get; set; }
        public decimal LbsO { get; set; }
        public decimal LbsR { get; set; }
        public decimal PrecioUnitario { get; set; }
        public decimal? Subtotal { get; set; }
        public decimal Descuento { get; set; }
        public decimal DescC { get; set; }
        public decimal? Total { get; set; }
    }
}
