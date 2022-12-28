using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class DiferidoDocCc2
    {
        public string Diferido { get; set; } = null!;
        public string TipoDoc { get; set; } = null!;
        public string Documento { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual Diferido2 DiferidoNavigation { get; set; } = null!;
        public virtual DocumentosCc2 DocumentosCc2 { get; set; } = null!;
    }
}
