using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class MayorAuditorium1
    {
        public MayorAuditorium1()
        {
            AsientoMayorizado1s = new HashSet<AsientoMayorizado1>();
            HistCierreCg1s = new HashSet<HistCierreCg1>();
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
        public virtual ICollection<AsientoMayorizado1> AsientoMayorizado1s { get; set; }
        public virtual ICollection<HistCierreCg1> HistCierreCg1s { get; set; }
    }
}
