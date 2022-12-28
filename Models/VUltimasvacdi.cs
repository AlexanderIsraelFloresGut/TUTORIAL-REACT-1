using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class VUltimasvacdi
    {
        public string Empleado { get; set; } = null!;
        public DateTime? Fecha { get; set; }
        public string TipoAccion { get; set; } = null!;
        public string? TipoAusencia { get; set; }
    }
}
