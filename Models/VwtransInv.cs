using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class VwtransInv
    {
        public string Aplicacion { get; set; } = null!;
        public string Articulo { get; set; } = null!;
        public decimal Cantidad { get; set; }
    }
}
