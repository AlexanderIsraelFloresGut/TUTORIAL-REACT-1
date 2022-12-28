using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class EmpleadoSaldoVac
    {
        public EmpleadoSaldoVac()
        {
            EmpSaldoVacAccs = new HashSet<EmpSaldoVacAcc>();
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

        public virtual Empleado EmpleadoNavigation { get; set; } = null!;
        public virtual Liquidacion? LiquidacionNavigation { get; set; }
        public virtual NominaHistorico? N { get; set; }
        public virtual RegimenVacacional RegimenVacacionalNavigation { get; set; } = null!;
        public virtual ICollection<EmpSaldoVacAcc> EmpSaldoVacAccs { get; set; }
    }
}
