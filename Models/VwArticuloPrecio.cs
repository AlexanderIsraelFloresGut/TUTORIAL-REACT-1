using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class VwArticuloPrecio
    {
        public string NivelPrecio { get; set; } = null!;
        public string Moneda { get; set; } = null!;
        public string Articulo { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public decimal Precio { get; set; }
    }
}
