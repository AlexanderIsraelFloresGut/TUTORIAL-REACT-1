using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class TipoAusencium
    {
        public TipoAusencium()
        {
            EmpleadoAccPers = new HashSet<EmpleadoAccPer>();
            EmpleadoAusencia = new HashSet<EmpleadoAusencium>();
            TipoSolicitudRhs = new HashSet<TipoSolicitudRh>();
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

        public virtual ICollection<EmpleadoAccPer> EmpleadoAccPers { get; set; }
        public virtual ICollection<EmpleadoAusencium> EmpleadoAusencia { get; set; }
        public virtual ICollection<TipoSolicitudRh> TipoSolicitudRhs { get; set; }
    }
}
