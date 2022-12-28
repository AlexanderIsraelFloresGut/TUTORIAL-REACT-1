using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class SolicitudRh1
    {
        public SolicitudRh1()
        {
            SolicitudRhAudit1s = new HashSet<SolicitudRhAudit1>();
            SolicitudRhDoc1s = new HashSet<SolicitudRhDoc1>();
            SolicitudRhNotif1s = new HashSet<SolicitudRhNotif1>();
        }

        public int SolicitudRh { get; set; }
        public string TipoSolicitudRh { get; set; } = null!;
        public string Empleado { get; set; } = null!;
        public string Estado { get; set; } = null!;
        public DateTime? FechaRige { get; set; }
        public DateTime? FechaVence { get; set; }
        public float? Dias { get; set; }
        public int? NumeroAccion { get; set; }
        public string GeneradaPor { get; set; } = null!;
        public DateTime FechaHora { get; set; }
        public DateTime FechaEstado { get; set; }
        public string? Observaciones { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual Empleado1 EmpleadoNavigation { get; set; } = null!;
        public virtual Empleado1 GeneradaPorNavigation { get; set; } = null!;
        public virtual EmpleadoAccPer1? NumeroAccionNavigation { get; set; }
        public virtual TipoSolicitudRh1 TipoSolicitudRhNavigation { get; set; } = null!;
        public virtual ICollection<SolicitudRhAudit1> SolicitudRhAudit1s { get; set; }
        public virtual ICollection<SolicitudRhDoc1> SolicitudRhDoc1s { get; set; }
        public virtual ICollection<SolicitudRhNotif1> SolicitudRhNotif1s { get; set; }
    }
}
