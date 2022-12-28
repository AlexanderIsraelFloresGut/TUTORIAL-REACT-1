using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class SolicitudRhDoc
    {
        public int SolicitudRh { get; set; }
        public int Documento { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual Documento DocumentoNavigation { get; set; } = null!;
        public virtual SolicitudRh SolicitudRhNavigation { get; set; } = null!;
    }
}
