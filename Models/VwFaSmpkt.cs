using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class VwFaSmpkt
    {
        public string Factura { get; set; } = null!;
        public DateTime Fecha { get; set; }
        public string Cliente { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public string Articulo { get; set; } = null!;
        public string? Producto { get; set; }
        public decimal Cantidad { get; set; }
        public decimal PesoBruto { get; set; }
        public decimal? Paquete { get; set; }
        public decimal? PPaquete { get; set; }
        public decimal? PTotal { get; set; }
    }
}
