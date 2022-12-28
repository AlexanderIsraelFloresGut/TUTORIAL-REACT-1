using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class TipoAccionAf1
    {
        public TipoAccionAf1()
        {
            ActivoAccion1s = new HashSet<ActivoAccion1>();
            SolicitudAfNotif1s = new HashSet<SolicitudAfNotif1>();
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

        public virtual ICollection<ActivoAccion1> ActivoAccion1s { get; set; }
        public virtual ICollection<SolicitudAfNotif1> SolicitudAfNotif1s { get; set; }
    }
}
