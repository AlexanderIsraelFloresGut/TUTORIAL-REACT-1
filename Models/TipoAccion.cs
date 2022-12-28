using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class TipoAccion
    {
        public TipoAccion()
        {
            CalculoVacacionals = new HashSet<CalculoVacacional>();
            ContribucionVacs = new HashSet<ContribucionVac>();
            EmpleadoAccPers = new HashSet<EmpleadoAccPer>();
            EmpleadoAuditoria = new HashSet<EmpleadoAuditorium>();
            RegimenVacacionals = new HashSet<RegimenVacacional>();
            SalDiarioInts = new HashSet<SalDiarioInt>();
            TipoAccionConceps = new HashSet<TipoAccionConcep>();
            TipoAccionUsuarios = new HashSet<TipoAccionUsuario>();
            TipoSolicitudRhs = new HashSet<TipoSolicitudRh>();
        }

        public string TipoAccion1 { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public string? Fija { get; set; }
        public short TipoAccionPredef { get; set; }
        public string? TextoPredef { get; set; }
        public string RestauraEstadoemp { get; set; } = null!;
        public string? CodifAplicRubros { get; set; }
        public string? EstadoEmpleado { get; set; }
        public string? ModEstadoEmp { get; set; }
        public string? Reporte { get; set; }
        public string? CodifTextopredefRubros { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
        public string? TipoIncapacidad { get; set; }

        public virtual EstadoEmpleado? EstadoEmpleadoNavigation { get; set; }
        public virtual TipoIncapacidad? TipoIncapacidadNavigation { get; set; }
        public virtual ICollection<CalculoVacacional> CalculoVacacionals { get; set; }
        public virtual ICollection<ContribucionVac> ContribucionVacs { get; set; }
        public virtual ICollection<EmpleadoAccPer> EmpleadoAccPers { get; set; }
        public virtual ICollection<EmpleadoAuditorium> EmpleadoAuditoria { get; set; }
        public virtual ICollection<RegimenVacacional> RegimenVacacionals { get; set; }
        public virtual ICollection<SalDiarioInt> SalDiarioInts { get; set; }
        public virtual ICollection<TipoAccionConcep> TipoAccionConceps { get; set; }
        public virtual ICollection<TipoAccionUsuario> TipoAccionUsuarios { get; set; }
        public virtual ICollection<TipoSolicitudRh> TipoSolicitudRhs { get; set; }
    }
}
