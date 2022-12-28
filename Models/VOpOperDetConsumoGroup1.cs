using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class VOpOperDetConsumoGroup1
    {
        public int NumLinea { get; set; }
        public string Articulo { get; set; } = null!;
        public string ClasificacionNombre { get; set; } = null!;
        public string ClasificacionValue { get; set; } = null!;
        public decimal CantidadConsumido { get; set; }
    }
}
