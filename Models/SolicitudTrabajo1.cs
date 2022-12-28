using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class SolicitudTrabajo1
    {
        public int Solicitud { get; set; }
        public string Estado { get; set; } = null!;
        public string Equipo { get; set; } = null!;
        public string Prioridad { get; set; } = null!;
        public string TipoMantenimiento { get; set; } = null!;
        public DateTime FechaSolicitud { get; set; }
        public string EmpSolicitante { get; set; } = null!;
        public DateTime FechaCreacion { get; set; }
        public string UsuarioCreacion { get; set; } = null!;
        public DateTime? FechaModificacion { get; set; }
        public string? UsuarioModifica { get; set; }
        public DateTime? FechaAprobacion { get; set; }
        public string? UsuarioAprobacion { get; set; }
        public DateTime? FechaCierre { get; set; }
        public string? UsuarioCierre { get; set; }
        public DateTime? FechaCancelacion { get; set; }
        public string? UsuarioCancela { get; set; }
        public int? OrdenTrabajo { get; set; }
        public string? Observaciones { get; set; }
        public string? CentroGasto { get; set; }
        public string DescripcionCorta { get; set; } = null!;
        public string? Procedimiento { get; set; }
        public string? TipoFalla { get; set; }
        public string? Version { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual CentroCosto1? CentroGastoNavigation { get; set; }
        public virtual Empleado1 EmpSolicitanteNavigation { get; set; } = null!;
        public virtual Equipo1 EquipoNavigation { get; set; } = null!;
        public virtual OrdenTrabajo1? OrdenTrabajoNavigation { get; set; }
        public virtual Usuario2? UsuarioAprobacionNavigation { get; set; }
        public virtual Usuario2? UsuarioCancelaNavigation { get; set; }
        public virtual Usuario2? UsuarioCierreNavigation { get; set; }
        public virtual Usuario2 UsuarioCreacionNavigation { get; set; } = null!;
        public virtual Usuario2? UsuarioModificaNavigation { get; set; }
    }
}
