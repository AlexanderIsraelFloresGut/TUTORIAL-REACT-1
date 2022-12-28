using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class BodegaEncargado1
    {
        public string Bodega { get; set; } = null!;
        public string Encargado { get; set; } = null!;
        public string? Empleado { get; set; }
        public string EMail { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual Bodega1 BodegaNavigation { get; set; } = null!;
        public virtual Empleado1? EmpleadoNavigation { get; set; }
    }
}
