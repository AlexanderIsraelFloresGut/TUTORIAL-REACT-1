using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class VwSaldocpxcategorium
    {
        public string Descripcion { get; set; } = null!;
        public string Proveedor { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public decimal Saldo { get; set; }
        public decimal SaldoDolar { get; set; }
        public decimal SaldoLocal { get; set; }
    }
}
