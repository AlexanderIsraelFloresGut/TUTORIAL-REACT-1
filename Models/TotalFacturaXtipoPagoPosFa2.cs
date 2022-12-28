using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class TotalFacturaXtipoPagoPosFa2
    {
        public string Factura { get; set; } = null!;
        public decimal? Totales { get; set; }
        public string? Consecutivo { get; set; }
        public string FormaPago { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public string TipoDocumento { get; set; } = null!;
    }
}
