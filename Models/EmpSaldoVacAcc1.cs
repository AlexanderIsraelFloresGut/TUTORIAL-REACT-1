using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class EmpSaldoVacAcc1
    {
        public string Empleado { get; set; } = null!;
        public int Consecutivo { get; set; }
        public int NumeroAccion { get; set; }
        public decimal Cantidad { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
        public string? Notas { get; set; }

        public virtual EmpleadoSaldoVac1 EmpleadoSaldoVac1 { get; set; } = null!;
    }
}
