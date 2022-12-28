using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class VwEcCpFull
    {
        public string Proveedor { get; set; } = null!;
        public string Documento { get; set; } = null!;
        public string Tipo { get; set; } = null!;
        public DateTime FechaDocumento { get; set; }
        public string Aplicacion { get; set; } = null!;
        public decimal Monto { get; set; }
        public decimal Saldo { get; set; }
        public decimal MontoLocal { get; set; }
        public decimal SaldoLocal { get; set; }
        public decimal MontoDolar { get; set; }
        public decimal SaldoDolar { get; set; }
        public decimal TipoCambioDolar { get; set; }
        public string Aprobado { get; set; } = null!;
        public decimal MontoProv { get; set; }
        public decimal SaldoProv { get; set; }
        public string Moneda { get; set; } = null!;
        public string Compania { get; set; } = null!;
    }
}
