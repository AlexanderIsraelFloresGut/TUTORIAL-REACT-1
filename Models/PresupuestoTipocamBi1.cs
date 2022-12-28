using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class PresupuestoTipocamBi1
    {
        public string Presupuesto { get; set; } = null!;
        public string Version { get; set; } = null!;
        public DateTime Mes { get; set; }
        public decimal MontoTipoCambio { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual PresupuestoVersionBi1 PresupuestoVersionBi1 { get; set; } = null!;
    }
}
