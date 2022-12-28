using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class ProcEqPreventMed
    {
        public ProcEqPreventMed()
        {
            FactProcMedics = new HashSet<FactProcMedic>();
        }

        public string Equipo { get; set; } = null!;
        public string Procedimiento { get; set; } = null!;
        public string Version { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual EquipoPrevent EquipoNavigation { get; set; } = null!;
        public virtual Procedimiento ProcedimientoNavigation { get; set; } = null!;
        public virtual ICollection<FactProcMedic> FactProcMedics { get; set; }
    }
}
