using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class OtDetalle
    {
        public OtDetalle()
        {
            OtPlanTrabajos = new HashSet<OtPlanTrabajo>();
        }

        public int OrdenTrabajo { get; set; }
        public short Consecutivo { get; set; }
        public short Secuencia { get; set; }
        public string Descripcion { get; set; } = null!;
        public string? Procedimiento { get; set; }
        public string? Version { get; set; }
        public string Equipo { get; set; } = null!;
        public string? EquipoPadre { get; set; }
        public string? TipoFalla { get; set; }
        public DateTime? FechaEstInicio { get; set; }
        public DateTime? FechaEstFin { get; set; }
        public DateTime? FechaProxMant { get; set; }
        public string Aprobado { get; set; } = null!;
        public string? UsuarioAprobacion { get; set; }
        public DateTime? FechaHoraAprobac { get; set; }
        public string? DetalleTrabajo { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual Equipo EquipoNavigation { get; set; } = null!;
        public virtual Equipo? EquipoPadreNavigation { get; set; }
        public virtual OrdenTrabajo OrdenTrabajoNavigation { get; set; } = null!;
        public virtual Procedimiento? ProcedimientoNavigation { get; set; }
        public virtual TipoFalla? TipoFallaNavigation { get; set; }
        public virtual Usuario2? UsuarioAprobacionNavigation { get; set; }
        public virtual ICollection<OtPlanTrabajo> OtPlanTrabajos { get; set; }
    }
}
