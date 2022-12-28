using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class HistCreditoEmp2
    {
        public string Empleado { get; set; } = null!;
        public int NumeroCredito { get; set; }
        public string Descontado { get; set; } = null!;
        public string? Nomina { get; set; }
        public short? NumeroNomina { get; set; }
        public decimal Total { get; set; }
        public string? Documento { get; set; }
        public int? NumeroLiquidac { get; set; }
        public int? NumeroLiquidacion { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual Empleado2 EmpleadoNavigation { get; set; } = null!;
        public virtual NominaHistorico2? N { get; set; }
        public virtual Liquidacion2? NumeroLiquidacionNavigation { get; set; }
    }
}
