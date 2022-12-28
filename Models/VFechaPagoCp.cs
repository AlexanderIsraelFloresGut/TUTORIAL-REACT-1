using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class VFechaPagoCp
    {
        public string Proveedor { get; set; } = null!;
        public string TipoFac { get; set; } = null!;
        public string Factura { get; set; } = null!;
        public DateTime? FechaPago { get; set; }
        public string Modulo { get; set; } = null!;
    }
}
