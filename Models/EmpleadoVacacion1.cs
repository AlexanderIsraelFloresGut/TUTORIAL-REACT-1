using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class EmpleadoVacacion1
    {
        public string Empleado { get; set; } = null!;
        public string RegimenVacacional { get; set; } = null!;
        public string CalculaVacaciones { get; set; } = null!;
        public decimal? UnidadVacacional { get; set; }
        public string? ContribPendientes { get; set; }
        public string? AdvContribNoapli { get; set; }
        public string? PermiteAcumNeg { get; set; }
        public string? RequiereVerific { get; set; }
        public string? NotasAdvertencia { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual Empleado1 EmpleadoNavigation { get; set; } = null!;
        public virtual RegimenVacacional1 RegimenVacacionalNavigation { get; set; } = null!;
    }
}
