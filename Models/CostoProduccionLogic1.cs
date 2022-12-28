using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class CostoProduccionLogic1
    {
        public string CodTransInv { get; set; } = null!;
        public int AuditTransInvLogic { get; set; }
        public int AuditTransInvErp { get; set; }
        public string Articulo { get; set; } = null!;
        public decimal CostoLocal { get; set; }
        public decimal CostoDolar { get; set; }
    }
}
