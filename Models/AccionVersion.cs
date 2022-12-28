using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class AccionVersion
    {
        public int Accion { get; set; }
        public string? UltVersion { get; set; }
        public string Usuario { get; set; } = null!;
        public DateTime FchHoraVersion { get; set; }
        public string UltVersionerp { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual Accion AccionNavigation { get; set; } = null!;
    }
}
