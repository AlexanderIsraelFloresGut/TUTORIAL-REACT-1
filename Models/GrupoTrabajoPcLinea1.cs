using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class GrupoTrabajoPcLinea1
    {
        public string GrupoTrabajo { get; set; } = null!;
        public string Empleado { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual Empleado1 EmpleadoNavigation { get; set; } = null!;
        public virtual GrupoTrabajoPc1 GrupoTrabajoNavigation { get; set; } = null!;
    }
}
