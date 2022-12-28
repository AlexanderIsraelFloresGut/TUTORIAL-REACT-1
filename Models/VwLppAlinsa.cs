using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class VwLppAlinsa
    {
        public int NumLista { get; set; }
        public string NombreLista { get; set; } = null!;
        public string Especie { get; set; } = null!;
        public string Articulo { get; set; } = null!;
        public string DescripcionArticulo { get; set; } = null!;
        public decimal PrecioLocal { get; set; }
        public decimal? PrecioDolar { get; set; }
    }
}
