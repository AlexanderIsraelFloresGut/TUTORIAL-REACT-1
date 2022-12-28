using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class LiquidacionAporte2
    {
        public int Liquidacion { get; set; }
        public string Concepto { get; set; } = null!;
        public string Moneda { get; set; } = null!;
        public DateTime FechaLiquidac { get; set; }
        public decimal? TipoCambio { get; set; }
        public decimal? TotalCalculado { get; set; }
        public decimal? TotalModificado { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual ConceptoLiquidac2 ConceptoLiquidac2 { get; set; } = null!;
        public virtual Liquidacion2 LiquidacionNavigation { get; set; } = null!;
    }
}
