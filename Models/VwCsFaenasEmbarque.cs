using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class VwCsFaenasEmbarque
    {
        public int? AñoRecepcion { get; set; }
        public int? MesRecepcion { get; set; }
        public string? Faena { get; set; }
        public string? Proveedor { get; set; }
        public string Nombre { get; set; } = null!;
        public string? Orden { get; set; }
        public string? Articulo { get; set; }
        public string Descripcion { get; set; } = null!;
        public decimal? Libras { get; set; }
    }
}
