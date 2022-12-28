using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class GastoCompra2
    {
        public GastoCompra2()
        {
            LiquidacGasto2s = new HashSet<LiquidacGasto2>();
        }

        public string GastoCompra { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public string TipoProrrateo { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual ICollection<LiquidacGasto2> LiquidacGasto2s { get; set; }
    }
}
