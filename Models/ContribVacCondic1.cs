using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class ContribVacCondic1
    {
        public string ContribucionVac { get; set; } = null!;
        public string? CondicionAplic { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual ContribucionVac1 ContribucionVacNavigation { get; set; } = null!;
    }
}
