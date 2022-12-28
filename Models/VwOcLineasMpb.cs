using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class VwOcLineasMpb
    {
        public int? Año { get; set; }
        public int? Mes { get; set; }
        public DateTime Fecha { get; set; }
        public string OrdenCompra { get; set; } = null!;
        public string Proveedor { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public string Articulo { get; set; } = null!;
        public string? Descripcion { get; set; }
        public decimal CantidadOrdenada { get; set; }
        public decimal CantidadRecibida { get; set; }
        public decimal PrecioUnitario { get; set; }
        public decimal MontoDescuento { get; set; }
        public decimal? Total { get; set; }
        public decimal? Neto { get; set; }
    }
}
