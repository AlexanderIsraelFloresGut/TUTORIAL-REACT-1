using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class TipoAccion2
    {
        public TipoAccion2()
        {
            CalculoVacacional2s = new HashSet<CalculoVacacional2>();
            ContribucionVac2s = new HashSet<ContribucionVac2>();
            EmpleadoAccPer2s = new HashSet<EmpleadoAccPer2>();
            EmpleadoAuditorium2s = new HashSet<EmpleadoAuditorium2>();
            RegimenVacacional2s = new HashSet<RegimenVacacional2>();
            SalDiarioInt2s = new HashSet<SalDiarioInt2>();
            TipoAccionConcep2s = new HashSet<TipoAccionConcep2>();
            TipoAccionUsuario2s = new HashSet<TipoAccionUsuario2>();
            TipoSolicitudRh2s = new HashSet<TipoSolicitudRh2>();
        }

        public string TipoAccion { get; set; } = null!;
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

        public virtual EstadoEmpleado2? EstadoEmpleadoNavigation { get; set; }
        public virtual TipoIncapacidad2? TipoIncapacidadNavigation { get; set; }
        public virtual ICollection<CalculoVacacional2> CalculoVacacional2s { get; set; }
        public virtual ICollection<ContribucionVac2> ContribucionVac2s { get; set; }
        public virtual ICollection<EmpleadoAccPer2> EmpleadoAccPer2s { get; set; }
        public virtual ICollection<EmpleadoAuditorium2> EmpleadoAuditorium2s { get; set; }
        public virtual ICollection<RegimenVacacional2> RegimenVacacional2s { get; set; }
        public virtual ICollection<SalDiarioInt2> SalDiarioInt2s { get; set; }
        public virtual ICollection<TipoAccionConcep2> TipoAccionConcep2s { get; set; }
        public virtual ICollection<TipoAccionUsuario2> TipoAccionUsuario2s { get; set; }
        public virtual ICollection<TipoSolicitudRh2> TipoSolicitudRh2s { get; set; }
    }
}
