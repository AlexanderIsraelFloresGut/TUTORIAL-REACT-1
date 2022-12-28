using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class EmpleadoAccSaldo1
    {
        public int Consecutivo { get; set; }
        public int NumeroAccion { get; set; }
        public string? Nomina { get; set; }
        public short? NumeroNomina { get; set; }
        public int? Liquidacion { get; set; }
        public decimal DiasAplicados { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual Liquidacion1? LiquidacionNavigation { get; set; }
        public virtual NominaHistorico1? N { get; set; }
        public virtual EmpleadoAccPer1 NumeroAccionNavigation { get; set; } = null!;
    }
}
