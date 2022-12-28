using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class OtPlanTrabajo
    {
        public DateTime FechaHoraReg { get; set; }
        public int? OrdenTrabajo { get; set; }
        public short? Consecutivo { get; set; }
        public string Puesto { get; set; } = null!;
        public string? Empleado { get; set; }
        public short Secuencia { get; set; }
        public DateTime FechaHoraInicio { get; set; }
        public DateTime? FechaHoraFin { get; set; }
        public decimal HorasAsignad { get; set; }
        public string? Comentario { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual Empleado? EmpleadoNavigation { get; set; }
        public virtual OtDetalle? OtDetalle { get; set; }
        public virtual Puesto PuestoNavigation { get; set; } = null!;
    }
}
