using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class TipoAusencium2
    {
        public TipoAusencium2()
        {
            EmpleadoAccPer2s = new HashSet<EmpleadoAccPer2>();
            EmpleadoAusencium2s = new HashSet<EmpleadoAusencium2>();
            TipoSolicitudRh2s = new HashSet<TipoSolicitudRh2>();
        }

        public string TipoAusencia { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public string Justificada { get; set; } = null!;
        public string Pago { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual ICollection<EmpleadoAccPer2> EmpleadoAccPer2s { get; set; }
        public virtual ICollection<EmpleadoAusencium2> EmpleadoAusencium2s { get; set; }
        public virtual ICollection<TipoSolicitudRh2> TipoSolicitudRh2s { get; set; }
    }
}
