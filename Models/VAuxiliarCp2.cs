using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class VAuxiliarCp2
    {
        public string Proveedor { get; set; } = null!;
        public string TipoDocDeb { get; set; } = null!;
        public string NumDeb { get; set; } = null!;
        public DateTime FechaPago { get; set; }
        public string SubtipoFac { get; set; } = null!;
        public string TipoFac { get; set; } = null!;
        public string NumCred { get; set; } = null!;
        public string NcfFac { get; set; } = null!;
        public decimal MontoLocal { get; set; }
        public string Modulo { get; set; } = null!;
    }
}
