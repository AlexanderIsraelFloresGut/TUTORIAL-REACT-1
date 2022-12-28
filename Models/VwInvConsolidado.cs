using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class VwInvConsolidado
    {
        public string Empresa { get; set; } = null!;
        public string Bodega { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public string Articulo { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public decimal Cantidad { get; set; }
    }
}
