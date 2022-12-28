using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class GastoCompra
    {
        public GastoCompra()
        {
            LiquidacGastos = new HashSet<LiquidacGasto>();
        }

        public string GastoCompra1 { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public string TipoProrrateo { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual ICollection<LiquidacGasto> LiquidacGastos { get; set; }
    }
}
