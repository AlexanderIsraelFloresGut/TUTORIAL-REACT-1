using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class LiqPcDesgRubro1
    {
        public string Liquidacion { get; set; } = null!;
        public string Rubro { get; set; } = null!;
        public string CelulaTrabajo { get; set; } = null!;
        public int? UnidadesEstimadas { get; set; }
        public decimal TotalEstimadoLoc { get; set; }
        public decimal? TotalEstimadoDol { get; set; }
        public decimal MovContableLocal { get; set; }
        public decimal? MovContableDolar { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual CelulaTrabajo1 CelulaTrabajoNavigation { get; set; } = null!;
        public virtual LiquidacionPc1 LiquidacionNavigation { get; set; } = null!;
        public virtual RubroLiq1 RubroNavigation { get; set; } = null!;
    }
}
