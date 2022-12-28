using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class ModuloAdicional
    {
        public string Iniciales { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public string? Firma { get; set; }
        public DateTime? FechaFirma { get; set; }
    }
}
