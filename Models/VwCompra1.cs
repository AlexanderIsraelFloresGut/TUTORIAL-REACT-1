using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class VwCompra1
    {
        public string OrdenCompra { get; set; } = null!;
        public string Estado { get; set; } = null!;
        public DateTime? FechaHora { get; set; }
        public DateTime? FechaAutorizada { get; set; }
        public int? Diferencia { get; set; }
    }
}
