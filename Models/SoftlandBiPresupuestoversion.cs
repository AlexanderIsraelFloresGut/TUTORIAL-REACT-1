using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class SoftlandBiPresupuestoversion
    {
        public string Codigo { get; set; } = null!;
        public string Version { get; set; } = null!;
        public string Estado { get; set; } = null!;
        public DateTime Mesinicial { get; set; }
        public DateTime Mesfinal { get; set; }
    }
}
