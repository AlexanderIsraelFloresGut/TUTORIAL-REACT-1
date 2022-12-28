using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class OtDetalle1
    {
        public OtDetalle1()
        {
            OtPlanTrabajo1s = new HashSet<OtPlanTrabajo1>();
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

        public virtual Equipo1 EquipoNavigation { get; set; } = null!;
        public virtual Equipo1? EquipoPadreNavigation { get; set; }
        public virtual OrdenTrabajo1 OrdenTrabajoNavigation { get; set; } = null!;
        public virtual Procedimiento1? Procedimiento1 { get; set; }
        public virtual TipoFalla1? TipoFallaNavigation { get; set; }
        public virtual Usuario2? UsuarioAprobacionNavigation { get; set; }
        public virtual ICollection<OtPlanTrabajo1> OtPlanTrabajo1s { get; set; }
    }
}
