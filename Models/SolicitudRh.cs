using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class SolicitudRh
    {
        public SolicitudRh()
        {
            SolicitudRhAudits = new HashSet<SolicitudRhAudit>();
            SolicitudRhDocs = new HashSet<SolicitudRhDoc>();
            SolicitudRhNotifs = new HashSet<SolicitudRhNotif>();
        }

        public int SolicitudRh1 { get; set; }
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

        public virtual Empleado EmpleadoNavigation { get; set; } = null!;
        public virtual Empleado GeneradaPorNavigation { get; set; } = null!;
        public virtual EmpleadoAccPer? NumeroAccionNavigation { get; set; }
        public virtual TipoSolicitudRh TipoSolicitudRhNavigation { get; set; } = null!;
        public virtual ICollection<SolicitudRhAudit> SolicitudRhAudits { get; set; }
        public virtual ICollection<SolicitudRhDoc> SolicitudRhDocs { get; set; }
        public virtual ICollection<SolicitudRhNotif> SolicitudRhNotifs { get; set; }
    }
}
