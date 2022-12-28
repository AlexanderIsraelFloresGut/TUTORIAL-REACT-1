using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class PrecioMaxFact
    {
        public string Factura { get; set; } = null!;
        public string Articulo { get; set; } = null!;
        public decimal PrecioUnitario { get; set; }
        public string NivelPrecio { get; set; } = null!;
        public string ArticuloArt { get; set; } = null!;
        public decimal Precio { get; set; }
        public DateTime Fecha { get; set; }
        public string Moneda { get; set; } = null!;
    }
}
