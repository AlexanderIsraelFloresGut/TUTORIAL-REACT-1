using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class EmpleadoDocumento2
    {
        public string Empleado { get; set; } = null!;
        public int Documento { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual Documento2 DocumentoNavigation { get; set; } = null!;
        public virtual Empleado2 EmpleadoNavigation { get; set; } = null!;
    }
}
