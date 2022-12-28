using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class VwEccpalinsalineal
    {
        public string Proveedor { get; set; } = null!;
        public DateTime FechaDocumento { get; set; }
        public string Documento { get; set; } = null!;
        public string Tipo { get; set; } = null!;
        public string Aplicacion { get; set; } = null!;
        public string? Asiento { get; set; }
        public string CreatedBy { get; set; } = null!;
        public decimal Monto { get; set; }
        public decimal MontoLocal { get; set; }
        public decimal SaldoLocal { get; set; }
        public decimal TipoCambioMoneda { get; set; }
    }
}
