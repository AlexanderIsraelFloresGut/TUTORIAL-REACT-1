using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class SalDiarioIntDet2
    {
        public int Consecutivo { get; set; }
        public string Concepto { get; set; } = null!;
        public string Empleado { get; set; } = null!;
        public decimal? Acumulado { get; set; }
        public decimal? ProporcionDiaria { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual Concepto2 ConceptoNavigation { get; set; } = null!;
        public virtual SalDiarioInt2 ConsecutivoNavigation { get; set; } = null!;
        public virtual Empleado2 EmpleadoNavigation { get; set; } = null!;
    }
}
