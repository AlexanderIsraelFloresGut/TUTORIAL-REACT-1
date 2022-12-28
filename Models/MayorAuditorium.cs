using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class MayorAuditorium
    {
        public MayorAuditorium()
        {
            AsientoMayorizados = new HashSet<AsientoMayorizado>();
            HistCierreCgs = new HashSet<HistCierreCg>();
        }

        public int MayorAuditoria { get; set; }
        public string Usuario { get; set; } = null!;
        public DateTime Fecha { get; set; }
        public string Comentario { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual Usuario2 UsuarioNavigation { get; set; } = null!;
        public virtual ICollection<AsientoMayorizado> AsientoMayorizados { get; set; }
        public virtual ICollection<HistCierreCg> HistCierreCgs { get; set; }
    }
}
