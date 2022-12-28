using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class ProcPuesto
    {
        public ProcPuesto()
        {
            RolEqPrevents = new HashSet<RolEqPrevent>();
        }

        public string Procedimiento { get; set; } = null!;
        public string Version { get; set; } = null!;
        public short Consecutivo { get; set; }
        public short Secuencia { get; set; }
        public string Puesto { get; set; } = null!;
        public decimal HorasTotalAgre { get; set; }
        public decimal HorasTotalCrono { get; set; }
        public decimal NumeroEmpleados { get; set; }
        public string? Comentario { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual Procedimiento ProcedimientoNavigation { get; set; } = null!;
        public virtual Puesto PuestoNavigation { get; set; } = null!;
        public virtual ICollection<RolEqPrevent> RolEqPrevents { get; set; }
    }
}
