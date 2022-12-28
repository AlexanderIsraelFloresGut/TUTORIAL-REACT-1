using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class VwEmbarquesAduana
    {
        public int? Año { get; set; }
        public int? Mes { get; set; }
        public string NoEmbarque { get; set; } = null!;
        public DateTime? FechaEmbarque { get; set; }
        public string? Proveedor { get; set; }
        public string? NombreProveedor { get; set; }
        public short? OcL { get; set; }
        public string Articulo { get; set; } = null!;
        public string? DescripcionDeArticulo { get; set; }
        public string? ArticuloDelProv { get; set; }
        public decimal Embarque { get; set; }
        public decimal Rechazo { get; set; }
        public decimal? Devolucion { get; set; }
        public decimal? CantidadEmb { get; set; }
        public decimal? PrecioDolar { get; set; }
        public decimal? TotalDolar { get; set; }
    }
}
