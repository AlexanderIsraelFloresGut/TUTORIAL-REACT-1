using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class ExvDocumentosCp
    {
        public Guid RowPointer { get; set; }
        public string CashPaidOut { get; set; } = null!;
        public string? Faena { get; set; }
    }
}
