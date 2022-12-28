using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class EmpleadoAccSaldo
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

        public virtual Liquidacion? LiquidacionNavigation { get; set; }
        public virtual NominaHistorico? N { get; set; }
        public virtual EmpleadoAccPer NumeroAccionNavigation { get; set; } = null!;
    }
}
