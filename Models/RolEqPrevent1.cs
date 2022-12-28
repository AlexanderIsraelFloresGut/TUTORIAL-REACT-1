using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class RolEqPrevent1
    {
        public string Equipo { get; set; } = null!;
        public string Procedimiento { get; set; } = null!;
        public string Version { get; set; } = null!;
        public short Consecutivo { get; set; }
        public string Puesto { get; set; } = null!;
        public string? Empleado { get; set; }
        public short ConsecEmp { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual Empleado1? EmpleadoNavigation { get; set; }
        public virtual EquipoPrevent1 EquipoNavigation { get; set; } = null!;
        public virtual ProcPuesto1 ProcPuesto1 { get; set; } = null!;
        public virtual Puesto1 PuestoNavigation { get; set; } = null!;
    }
}
