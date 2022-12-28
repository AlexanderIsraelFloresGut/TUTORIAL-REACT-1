using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class OpOperacionRubro2
    {
        public string OrdenProduccion { get; set; } = null!;
        public string Operacion { get; set; } = null!;
        public string Rubro { get; set; } = null!;
        public decimal? CantidadEstandar { get; set; }
        public decimal CostUnitEstdLoc { get; set; }
        public decimal? CostUnitEstdDol { get; set; }
        public decimal CantidadReal { get; set; }
        public decimal CostRealLocal { get; set; }
        public decimal? CostRealDolar { get; set; }
        public decimal CantidadLiquid { get; set; }
        public decimal CostLiquidLocal { get; set; }
        public decimal? CostLiquidDolar { get; set; }
        public decimal PorcentLiquidado { get; set; }
        public string? Notas { get; set; }
        public decimal FactorConversion { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual OpOperacion2 O { get; set; } = null!;
    }
}
