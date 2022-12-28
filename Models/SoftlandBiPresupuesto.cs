using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class SoftlandBiPresupuesto
    {
        public string Codigo { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public string CodigoDescripcion { get; set; } = null!;
        public string Moneda { get; set; } = null!;
        public string Tipocontabilidad { get; set; } = null!;
    }
}
