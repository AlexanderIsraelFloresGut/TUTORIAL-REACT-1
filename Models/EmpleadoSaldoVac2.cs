using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class EmpleadoSaldoVac2
    {
        public EmpleadoSaldoVac2()
        {
            EmpSaldoVacAcc2s = new HashSet<EmpSaldoVacAcc2>();
        }

        public string Empleado { get; set; } = null!;
        public int Consecutivo { get; set; }
        public string RegimenVacacional { get; set; } = null!;
        public short Anno { get; set; }
        public decimal Acumulado { get; set; }
        public decimal SaldoActual { get; set; }
        public string? Nomina { get; set; }
        public short? NumeroNomina { get; set; }
        public int? Liquidacion { get; set; }
        public decimal SaldoActualAdic { get; set; }
        public decimal AcumuladoAdic { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual Empleado2 EmpleadoNavigation { get; set; } = null!;
        public virtual Liquidacion2? LiquidacionNavigation { get; set; }
        public virtual NominaHistorico2? N { get; set; }
        public virtual RegimenVacacional2 RegimenVacacionalNavigation { get; set; } = null!;
        public virtual ICollection<EmpSaldoVacAcc2> EmpSaldoVacAcc2s { get; set; }
    }
}
