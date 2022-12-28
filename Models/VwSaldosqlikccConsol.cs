using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class VwSaldosqlikccConsol
    {
        public string Cat { get; set; } = null!;
        public string CategoriaCliente { get; set; } = null!;
        public string Cliente { get; set; } = null!;
        public string? Alias { get; set; }
        public string Nombre { get; set; } = null!;
        public string Documento { get; set; } = null!;
        public string Aplicacion { get; set; } = null!;
        public DateTime FechaDocumento { get; set; }
        public decimal Monto { get; set; }
        public decimal MontoDolar { get; set; }
        public decimal MontoLocal { get; set; }
        public decimal Saldo { get; set; }
        public decimal SaldoDolar { get; set; }
        public decimal SaldoLocal { get; set; }
        public string Empresa { get; set; } = null!;
    }
}
