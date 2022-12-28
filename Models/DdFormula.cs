using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class DdFormula
    {
        public DdFormula()
        {
            DdFormulaCases = new HashSet<DdFormulaCase>();
        }

        public Guid IdFormula { get; set; }
        public string Formula { get; set; } = null!;
        public string? Condicion { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual ICollection<DdFormulaCase> DdFormulaCases { get; set; }
    }
}
