using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class CalcVacDetalle
    {
        public string ContribucionVac { get; set; } = null!;
        public string Empleado { get; set; } = null!;
        public int CalculoVacacional { get; set; }
        public string? UsuarioUltModif { get; set; }
        public int? AccionPersonal { get; set; }
        public string ContribCalculada { get; set; } = null!;
        public string? RequiereRecalculo { get; set; }
        public DateTime FechaInicial { get; set; }
        public DateTime FechaFinal { get; set; }
        public decimal? CantidadCalculada { get; set; }
        public decimal? CantidadModific { get; set; }
        public DateTime? FechaUltModif { get; set; }
        public string? Notas { get; set; }
        public short Consecutivo { get; set; }
        public string Fraccion { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual EmpleadoAccPer? AccionPersonalNavigation { get; set; }
        public virtual CalculoVacacional CalculoVacacionalNavigation { get; set; } = null!;
        public virtual ContribucionVac ContribucionVacNavigation { get; set; } = null!;
        public virtual Empleado EmpleadoNavigation { get; set; } = null!;
        public virtual Usuario2? UsuarioUltModifNavigation { get; set; }
    }
}
