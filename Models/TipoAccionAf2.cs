using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class TipoAccionAf2
    {
        public TipoAccionAf2()
        {
            ActivoAccion2s = new HashSet<ActivoAccion2>();
            SolicitudAfNotif2s = new HashSet<SolicitudAfNotif2>();
        }

        public string TipoAccionAf { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public short TipoAccionPredef { get; set; }
        public string? TextoPredef { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual ICollection<ActivoAccion2> ActivoAccion2s { get; set; }
        public virtual ICollection<SolicitudAfNotif2> SolicitudAfNotif2s { get; set; }
    }
}
