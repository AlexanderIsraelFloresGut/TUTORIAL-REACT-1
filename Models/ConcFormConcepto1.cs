using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class ConcFormConcepto1
    {
        public string Concepto { get; set; } = null!;
        public short Secuencia { get; set; }
        public string ConceptoUsa { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual ConceptoFormula1 ConceptoFormula1 { get; set; } = null!;
        public virtual Concepto1 ConceptoUsaNavigation { get; set; } = null!;
    }
}
