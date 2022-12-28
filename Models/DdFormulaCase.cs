using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class DdFormulaCase
    {
        public Guid IdFormula { get; set; }
        public Guid IdCase { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual DdColumnaCase IdCaseNavigation { get; set; } = null!;
        public virtual DdFormula IdFormulaNavigation { get; set; } = null!;
    }
}
