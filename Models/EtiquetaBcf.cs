using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class EtiquetaBcf
    {
        public string Articulo { get; set; } = null!;
        public string? Descripcion { get; set; }
        public string? CodigoBarra { get; set; }
        public string? CodigoBarra2 { get; set; }
        public int? Anio { get; set; }
        public int? Mes { get; set; }
    }
}
