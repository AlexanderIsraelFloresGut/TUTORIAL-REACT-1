using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class DeprCentroCosto2
    {
        public int HistDepreciacion { get; set; }
        public string CentroCosto { get; set; } = null!;
        public decimal DeprLocal { get; set; }
        public decimal DeprDolar { get; set; }
        public string? Fase { get; set; }
        public int CentroDepre { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual CentroCosto2 CentroCostoNavigation { get; set; } = null!;
        public virtual HistDepreciacion2 HistDepreciacionNavigation { get; set; } = null!;
    }
}
