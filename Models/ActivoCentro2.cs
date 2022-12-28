using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class ActivoCentro2
    {
        public string ActivoFijo { get; set; } = null!;
        public string CentroCosto { get; set; } = null!;
        public decimal Porcentaje { get; set; }
        public string? Fase { get; set; }
        public int ActivoCentro { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual ActivoFijo2 ActivoFijoNavigation { get; set; } = null!;
        public virtual CentroCosto2 CentroCostoNavigation { get; set; } = null!;
    }
}
