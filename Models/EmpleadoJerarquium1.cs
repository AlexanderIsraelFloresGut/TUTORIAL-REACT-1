using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class EmpleadoJerarquium1
    {
        public string Superior { get; set; } = null!;
        public string Subordinado { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual Empleado1 SubordinadoNavigation { get; set; } = null!;
        public virtual Empleado1 SuperiorNavigation { get; set; } = null!;
    }
}
