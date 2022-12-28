using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class TipoAccion1
    {
        public TipoAccion1()
        {
            CalculoVacacional1s = new HashSet<CalculoVacacional1>();
            ContribucionVac1s = new HashSet<ContribucionVac1>();
            EmpleadoAccPer1s = new HashSet<EmpleadoAccPer1>();
            EmpleadoAuditorium1s = new HashSet<EmpleadoAuditorium1>();
            RegimenVacacional1s = new HashSet<RegimenVacacional1>();
            SalDiarioInt1s = new HashSet<SalDiarioInt1>();
            TipoAccionConcep1s = new HashSet<TipoAccionConcep1>();
            TipoAccionUsuario1s = new HashSet<TipoAccionUsuario1>();
            TipoSolicitudRh1s = new HashSet<TipoSolicitudRh1>();
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

        public virtual EstadoEmpleado1? EstadoEmpleadoNavigation { get; set; }
        public virtual TipoIncapacidad1? TipoIncapacidadNavigation { get; set; }
        public virtual ICollection<CalculoVacacional1> CalculoVacacional1s { get; set; }
        public virtual ICollection<ContribucionVac1> ContribucionVac1s { get; set; }
        public virtual ICollection<EmpleadoAccPer1> EmpleadoAccPer1s { get; set; }
        public virtual ICollection<EmpleadoAuditorium1> EmpleadoAuditorium1s { get; set; }
        public virtual ICollection<RegimenVacacional1> RegimenVacacional1s { get; set; }
        public virtual ICollection<SalDiarioInt1> SalDiarioInt1s { get; set; }
        public virtual ICollection<TipoAccionConcep1> TipoAccionConcep1s { get; set; }
        public virtual ICollection<TipoAccionUsuario1> TipoAccionUsuario1s { get; set; }
        public virtual ICollection<TipoSolicitudRh1> TipoSolicitudRh1s { get; set; }
    }
}
