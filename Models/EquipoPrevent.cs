using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class EquipoPrevent
    {
        public EquipoPrevent()
        {
            ProcEqPreventMeds = new HashSet<ProcEqPreventMed>();
            ProcEqPrevents = new HashSet<ProcEqPrevent>();
            RolEqPrevents = new HashSet<RolEqPrevent>();
        }

        public string Equipo { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual Equipo EquipoNavigation { get; set; } = null!;
        public virtual ICollection<ProcEqPreventMed> ProcEqPreventMeds { get; set; }
        public virtual ICollection<ProcEqPrevent> ProcEqPrevents { get; set; }
        public virtual ICollection<RolEqPrevent> RolEqPrevents { get; set; }
    }
}
