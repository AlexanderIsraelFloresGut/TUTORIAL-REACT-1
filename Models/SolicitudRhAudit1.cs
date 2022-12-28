using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class SolicitudRhAudit1
    {
        public int SolicitudRh { get; set; }
        public string Usuario { get; set; } = null!;
        public short Nivel { get; set; }
        public string Estado { get; set; } = null!;
        public DateTime FechaEstado { get; set; }
        public string? Observaciones { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual SolicitudRh1 SolicitudRhNavigation { get; set; } = null!;
    }
}
