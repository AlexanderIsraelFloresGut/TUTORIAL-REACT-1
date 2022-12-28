using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class VwEmbLineasMpb
    {
        public int? Año { get; set; }
        public int? Mes { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string Moneda { get; set; } = null!;
        public DateTime? FechaEmbarque { get; set; }
        public string Embarque { get; set; } = null!;
        public string? OrdenCompra { get; set; }
        public string? Proveedor { get; set; }
        public string Nombre { get; set; } = null!;
        public string Articulo { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public decimal CantidadEmbarcada { get; set; }
        public decimal PrecioUnitario { get; set; }
        public decimal? Total { get; set; }
        public decimal? DescuentoLinea { get; set; }
        public decimal? Neto { get; set; }
    }
}
