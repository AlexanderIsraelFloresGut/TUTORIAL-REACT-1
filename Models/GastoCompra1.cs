using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class GastoCompra1
    {
        public GastoCompra1()
        {
            LiquidacGasto1s = new HashSet<LiquidacGasto1>();
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

        public virtual ICollection<LiquidacGasto1> LiquidacGasto1s { get; set; }
    }
}
