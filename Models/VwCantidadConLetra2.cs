using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class VwCantidadConLetra2
    {
        public string CajaChica { get; set; } = null!;
        public string Beneficiario { get; set; } = null!;
        public int Consecutivo { get; set; }
        public string Vale { get; set; } = null!;
        public decimal MontoCaja { get; set; }
        public string? CantidadLetras { get; set; }
    }
}
