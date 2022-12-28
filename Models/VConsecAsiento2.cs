using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class VConsecAsiento2
    {
        public int AuditTransInv { get; set; }
        public string Articulo { get; set; } = null!;
        public string? Asiento { get; set; }
        public int ConsecAsiento { get; set; }
        public decimal Cantidad { get; set; }
    }
}
