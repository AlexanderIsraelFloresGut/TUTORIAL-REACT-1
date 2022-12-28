using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class SoftlandBiCentrocosto
    {
        public string Codigo { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public string CodigoNombre { get; set; } = null!;
        public string? Centropadre { get; set; }
        public string? CentropadreNombre { get; set; }
    }
}
