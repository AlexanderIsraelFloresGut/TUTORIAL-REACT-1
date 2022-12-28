using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class VOpOperDetMoGroup
    {
        public DateTime FechaHoraProduc { get; set; }
        public string ClasificacionNombre { get; set; } = null!;
        public string ClasificacionValue { get; set; } = null!;
        public decimal CantHorasMoe { get; set; }
        public decimal CantHorasMop { get; set; }
    }
}
