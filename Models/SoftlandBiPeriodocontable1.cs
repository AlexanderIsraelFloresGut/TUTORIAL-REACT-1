using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class SoftlandBiPeriodocontable1
    {
        public DateTime Fechafinal { get; set; }
        public string Descripcion { get; set; } = null!;
        public string? Contabilidad { get; set; }
        public string Finperiodoanual { get; set; } = null!;
        public string Finperiodocorp { get; set; } = null!;
        public string Cierrefiscal { get; set; } = null!;
        public string Cierrecorp { get; set; } = null!;
    }
}
