using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class EmpExperiencium2
    {
        public string Empleado { get; set; } = null!;
        public short Consecutivo { get; set; }
        public DateTime FechaIngreso { get; set; }
        public DateTime? FechaSalida { get; set; }
        public string Empresa { get; set; } = null!;
        public string Puesto { get; set; } = null!;
        public string? MotivoSalida { get; set; }
        public string? Referencia { get; set; }
        public string? TelReferencia { get; set; }
        public string? EmailReferencia { get; set; }
        public string? Funciones { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual Empleado2 EmpleadoNavigation { get; set; } = null!;
    }
}
