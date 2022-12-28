using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class SolicitudRh2
    {
        public SolicitudRh2()
        {
            SolicitudRhAudit2s = new HashSet<SolicitudRhAudit2>();
            SolicitudRhDoc2s = new HashSet<SolicitudRhDoc2>();
            SolicitudRhNotif2s = new HashSet<SolicitudRhNotif2>();
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

        public virtual Empleado2 EmpleadoNavigation { get; set; } = null!;
        public virtual Empleado2 GeneradaPorNavigation { get; set; } = null!;
        public virtual EmpleadoAccPer2? NumeroAccionNavigation { get; set; }
        public virtual TipoSolicitudRh2 TipoSolicitudRhNavigation { get; set; } = null!;
        public virtual ICollection<SolicitudRhAudit2> SolicitudRhAudit2s { get; set; }
        public virtual ICollection<SolicitudRhDoc2> SolicitudRhDoc2s { get; set; }
        public virtual ICollection<SolicitudRhNotif2> SolicitudRhNotif2s { get; set; }
    }
}
