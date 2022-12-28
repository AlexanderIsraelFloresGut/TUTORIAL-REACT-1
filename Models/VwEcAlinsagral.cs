using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class VwEcAlinsagral
    {
        public string Proveedor { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public DateTime FechaDocumento { get; set; }
        public string Documento { get; set; } = null!;
        public string Tipo { get; set; } = null!;
        public short? Subtipo { get; set; }
        public string Aplicacion { get; set; } = null!;
        public string Moneda { get; set; } = null!;
        public decimal TipoCambioMoneda { get; set; }
        public decimal Monto { get; set; }
        public decimal MontoDolar { get; set; }
        public decimal? MontoCord { get; set; }
    }
}
