using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class TipoAusencium1
    {
        public TipoAusencium1()
        {
            EmpleadoAccPer1s = new HashSet<EmpleadoAccPer1>();
            EmpleadoAusencium1s = new HashSet<EmpleadoAusencium1>();
            TipoSolicitudRh1s = new HashSet<TipoSolicitudRh1>();
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

        public virtual ICollection<EmpleadoAccPer1> EmpleadoAccPer1s { get; set; }
        public virtual ICollection<EmpleadoAusencium1> EmpleadoAusencium1s { get; set; }
        public virtual ICollection<TipoSolicitudRh1> TipoSolicitudRh1s { get; set; }
    }
}
