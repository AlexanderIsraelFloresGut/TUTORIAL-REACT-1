using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class EquipoPrevent1
    {
        public EquipoPrevent1()
        {
            ProcEqPrevent1s = new HashSet<ProcEqPrevent1>();
            ProcEqPreventMed1s = new HashSet<ProcEqPreventMed1>();
            RolEqPrevent1s = new HashSet<RolEqPrevent1>();
        }

        public string Equipo { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual Equipo1 EquipoNavigation { get; set; } = null!;
        public virtual ICollection<ProcEqPrevent1> ProcEqPrevent1s { get; set; }
        public virtual ICollection<ProcEqPreventMed1> ProcEqPreventMed1s { get; set; }
        public virtual ICollection<RolEqPrevent1> RolEqPrevent1s { get; set; }
    }
}
