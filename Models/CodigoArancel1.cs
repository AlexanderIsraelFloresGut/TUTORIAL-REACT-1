using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class CodigoArancel1
    {
        public CodigoArancel1()
        {
            ArancelImpuesto1s = new HashSet<ArancelImpuesto1>();
            ArticuloCompra1s = new HashSet<ArticuloCompra1>();
            ExcepcionArancelPai1s = new HashSet<ExcepcionArancelPai1>();
        }

        public string CodigoArancel { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public string? Notas { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual ICollection<ArancelImpuesto1> ArancelImpuesto1s { get; set; }
        public virtual ICollection<ArticuloCompra1> ArticuloCompra1s { get; set; }
        public virtual ICollection<ExcepcionArancelPai1> ExcepcionArancelPai1s { get; set; }
    }
}
