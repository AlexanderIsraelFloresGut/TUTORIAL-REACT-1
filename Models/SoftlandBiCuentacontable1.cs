using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class SoftlandBiCuentacontable1
    {
        public string? Codigo { get; set; }
        public string Nombre { get; set; } = null!;
        public string? CodigoNombre { get; set; }
        public string Tipo { get; set; } = null!;
        public string TipoDetallado { get; set; } = null!;
        public string SaldoNormal { get; set; } = null!;
        public string SeccionCuenta { get; set; } = null!;
        public string? Cuentapadre { get; set; }
        public string? CuentapadreCodigoNombre { get; set; }
    }
}
