using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class VwBodegao
    {
        public int AuditTransInv { get; set; }
        public int Consecutivo { get; set; }
        public string? Bodega { get; set; }
        public string Nombre { get; set; } = null!;
    }
}
