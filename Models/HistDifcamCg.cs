using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class HistDifcamCg
    {
        public string UsuarioAuditoria { get; set; } = null!;
        public DateTime FechaAuditoria { get; set; }
        public DateTime FechaProc { get; set; }
        public decimal TipoCambioProc { get; set; }
        public string AsientoProc { get; set; } = null!;
        public Guid IdHist { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual Usuario2 UsuarioAuditoriaNavigation { get; set; } = null!;
    }
}
