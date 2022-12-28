using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class TipoAccionAf
    {
        public TipoAccionAf()
        {
            ActivoAccions = new HashSet<ActivoAccion>();
            SolicitudAfNotifs = new HashSet<SolicitudAfNotif>();
        }

        public string TipoAccionAf1 { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public short TipoAccionPredef { get; set; }
        public string? TextoPredef { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual ICollection<ActivoAccion> ActivoAccions { get; set; }
        public virtual ICollection<SolicitudAfNotif> SolicitudAfNotifs { get; set; }
    }
}
