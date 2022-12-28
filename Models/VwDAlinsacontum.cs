using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class VwDAlinsacontum
    {
        public string Asiento { get; set; } = null!;
        public int Consecutivo { get; set; }
        public string CentroCosto { get; set; } = null!;
        public string CuentaContable { get; set; } = null!;
        public string NombreCta { get; set; } = null!;
        public string Fuente { get; set; } = null!;
        public decimal DebitoLocal { get; set; }
        public decimal CreditoLocal { get; set; }
    }
}
