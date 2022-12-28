using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class SalDiarioIntEmp1
    {
        public int Consecutivo { get; set; }
        public string Empleado { get; set; } = null!;
        public int? NumeroAccion { get; set; }
        public decimal SalarioReferencia { get; set; }
        public decimal SdiAnterior { get; set; }
        public decimal DiasAntiguedad { get; set; }
        public decimal DiasVacaciones { get; set; }
        public decimal DiasLaborados { get; set; }
        public decimal DiasAguinaldo { get; set; }
        public decimal PorcentajePrima { get; set; }
        public decimal Factor { get; set; }
        public decimal SdiFijo { get; set; }
        public decimal SdiVariable { get; set; }
        public decimal SdiNuevo { get; set; }
        public string MarcaCalculo { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual SalDiarioInt1 ConsecutivoNavigation { get; set; } = null!;
        public virtual Empleado1 EmpleadoNavigation { get; set; } = null!;
        public virtual EmpleadoAccPer1? NumeroAccionNavigation { get; set; }
    }
}
