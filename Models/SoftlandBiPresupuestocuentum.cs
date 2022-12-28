using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class SoftlandBiPresupuestocuentum
    {
        public string Codigo { get; set; } = null!;
        public string Version { get; set; } = null!;
        public string? CuentaContable { get; set; }
    }
}
