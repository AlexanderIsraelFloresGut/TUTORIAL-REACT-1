using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class OpOperCostAux1
    {
        public string OrdenProduccion { get; set; } = null!;
        public string Operacion { get; set; } = null!;
        public string Liquidacion { get; set; } = null!;
        public decimal VariaRealMatL { get; set; }
        public decimal VariaRealMopL { get; set; }
        public decimal VariaRealMoeL { get; set; }
        public decimal VariaRealGifL { get; set; }
        public decimal? VariaRealMatD { get; set; }
        public decimal? VariaRealMopD { get; set; }
        public decimal? VariaRealMoeD { get; set; }
        public decimal? VariaRealGifD { get; set; }
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
