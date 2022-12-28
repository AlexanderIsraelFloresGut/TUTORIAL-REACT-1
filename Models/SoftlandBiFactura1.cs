using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class SoftlandBiFactura1
    {
        public string Facturacompuesta { get; set; } = null!;
        public string Tipodocumento { get; set; } = null!;
        public string Factura { get; set; } = null!;
        public DateTime? Fecha { get; set; }
        public string Tipodescuento1 { get; set; } = null!;
        public string Tipodescuent2 { get; set; } = null!;
        public string Anulada { get; set; } = null!;
        public string Moneda { get; set; } = null!;
        public string Cobrador { get; set; } = null!;
        public string Ruta { get; set; } = null!;
        public string Zona { get; set; } = null!;
        public string Vendedor { get; set; } = null!;
        public string Cliente { get; set; } = null!;
        public string Pais { get; set; } = null!;
    }
}
