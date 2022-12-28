using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class DocsProcedim
    {
        public string Procedimiento { get; set; } = null!;
        public string Version { get; set; } = null!;
        public short Numero { get; set; }
        public string Direccion { get; set; } = null!;
        public string? Comentario { get; set; }
        public string Imprimir { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual Procedimiento ProcedimientoNavigation { get; set; } = null!;
    }
}
