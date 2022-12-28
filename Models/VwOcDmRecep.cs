using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class VwOcDmRecep
    {
        public string OrdenCompraBcf { get; set; } = null!;
        public string ProvBcf { get; set; } = null!;
        public string ProvBcfNombre { get; set; } = null!;
        public string? TipoAlinsa { get; set; }
        public string? ProvAlinsa { get; set; }
        public string Articulo { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public decimal Libras { get; set; }
        public decimal Rechazo { get; set; }
    }
}
