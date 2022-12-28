using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class OpOperContLiq1
    {
        public string OrdenProduccion { get; set; } = null!;
        public string Operacion { get; set; } = null!;
        public string Liquidacion { get; set; } = null!;
        public decimal UnidadesContLiq { get; set; }
        public decimal TotalLocContInv { get; set; }
        public decimal? TotalDolContInv { get; set; }
        public decimal TotalLocContVar { get; set; }
        public decimal? TotalDolContVar { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual LiquidacionPc1 LiquidacionNavigation { get; set; } = null!;
        public virtual OpOperacion1 O { get; set; } = null!;
    }
}
