using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class HookDetalle
    {
        public string Hook { get; set; } = null!;
        public int Consecutivo { get; set; }
        public DateTime Fecha { get; set; }
        public string? Descripcion { get; set; }
        public byte[] Archivo { get; set; } = null!;
        public string? Crc { get; set; }
        public string? Vigente { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual HookPersonaliz HookNavigation { get; set; } = null!;
    }
}
