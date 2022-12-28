using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class VwListaPrecioVtum
    {
        public string NivelPrecio { get; set; } = null!;
        public string? Tipo { get; set; }
        public string? Especie { get; set; }
        public string Articulo { get; set; } = null!;
        public string? ArticuloDescripcion { get; set; }
        public string MonedaPrecio { get; set; } = null!;
        public decimal PrecioVta { get; set; }
    }
}
