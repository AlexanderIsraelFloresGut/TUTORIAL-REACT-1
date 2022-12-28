using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class RegimenVacContri1
    {
        public string ContribucionVacac { get; set; } = null!;
        public string RegimenVacacional { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual ContribucionVac1 ContribucionVacacNavigation { get; set; } = null!;
        public virtual RegimenVacacional1 RegimenVacacionalNavigation { get; set; } = null!;
    }
}
