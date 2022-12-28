using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class ContribVacForm
    {
        public string ContribucionVac { get; set; } = null!;
        public string? FormulaCalculo { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual ContribucionVac ContribucionVacNavigation { get; set; } = null!;
    }
}
