using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class LiquidacionesIgss2
    {
        public int NumLiqIgss { get; set; }
        public string Nomina { get; set; } = null!;
        public string TipoPlanillaIgss { get; set; } = null!;
        public string TipoCompOrig { get; set; } = null!;
        public int NumNotaCargo { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
    }
}
