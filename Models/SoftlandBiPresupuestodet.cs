using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class SoftlandBiPresupuestodet
    {
        public string Codigo { get; set; } = null!;
        public string Version { get; set; } = null!;
        public string CentroCosto { get; set; } = null!;
        public string CuentaContable { get; set; } = null!;
        public DateTime Mes { get; set; }
        public decimal? Montolocal { get; set; }
        public decimal? Montodolar { get; set; }
    }
}
