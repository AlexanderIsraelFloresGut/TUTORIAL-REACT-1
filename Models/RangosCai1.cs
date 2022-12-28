using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class RangosCai1
    {
        public string Cai { get; set; } = null!;
        public string Consecutivo { get; set; } = null!;
        public string TipoDocumento { get; set; } = null!;
        public string? UsaConsecutivoGlobal { get; set; }
        public string? TipoRetencion { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
    }
}
