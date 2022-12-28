using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class OtReporteLabor
    {
        public int OrdenTrabajo { get; set; }
        public string Referencia { get; set; } = null!;
        public short Consecutivo { get; set; }
        public string Empleado { get; set; } = null!;
        public string Puesto { get; set; } = null!;
        public string Equipo { get; set; } = null!;
        public decimal CantidadHoras { get; set; }
        public decimal CostoHoraLocal { get; set; }
        public decimal CostoHoraDolar { get; set; }
        public decimal? HorasExtras { get; set; }
        public decimal? HorasDobles { get; set; }
        public string? Comentario { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual Empleado EmpleadoNavigation { get; set; } = null!;
        public virtual Equipo EquipoNavigation { get; set; } = null!;
        public virtual Puesto PuestoNavigation { get; set; } = null!;
        public virtual ReporteLabor ReporteLabor { get; set; } = null!;
    }
}
