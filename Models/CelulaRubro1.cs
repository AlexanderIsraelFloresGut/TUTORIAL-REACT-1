using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class CelulaRubro1
    {
        public string CelulaTrabajo { get; set; } = null!;
        public string Rubro { get; set; } = null!;
        public string? AsociacionContab { get; set; }
        public decimal FactorConversion { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual CelulaTrabajo1 CelulaTrabajoNavigation { get; set; } = null!;
        public virtual RubroLiq1 RubroNavigation { get; set; } = null!;
        public virtual CelulaRubroNota1 CelulaRubroNota1 { get; set; } = null!;
    }
}
