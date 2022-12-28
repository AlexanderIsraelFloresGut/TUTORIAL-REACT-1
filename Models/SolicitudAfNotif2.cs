﻿using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class SolicitudAfNotif2
    {
        public SolicitudAfNotif2()
        {
            DetSolicitudAfNotif2s = new HashSet<DetSolicitudAfNotif2>();
            SolicitudAfAudit2s = new HashSet<SolicitudAfAudit2>();
        }

        public int Solicitud { get; set; }
        public string ResponsableCreador { get; set; } = null!;
        public string ResponsableTraslado { get; set; } = null!;
        public string ResponsableCreadopor { get; set; } = null!;
        public string EstadoSolicitud { get; set; } = null!;
        public string TipoAccion { get; set; } = null!;
        public DateTime? Fecha { get; set; }
        public DateTime FechaRige { get; set; }
        public string? Notas { get; set; }
        public int? CambiaCentroCosto { get; set; }
        public int? GenOtroResp { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual Responsable2 ResponsableCreadoporNavigation { get; set; } = null!;
        public virtual Responsable2 ResponsableCreadorNavigation { get; set; } = null!;
        public virtual Responsable2 ResponsableTrasladoNavigation { get; set; } = null!;
        public virtual TipoAccionAf2 TipoAccionNavigation { get; set; } = null!;
        public virtual ICollection<DetSolicitudAfNotif2> DetSolicitudAfNotif2s { get; set; }
        public virtual ICollection<SolicitudAfAudit2> SolicitudAfAudit2s { get; set; }
    }
}
