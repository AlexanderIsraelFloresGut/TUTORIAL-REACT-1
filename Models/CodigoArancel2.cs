using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class CodigoArancel2
    {
        public CodigoArancel2()
        {
            ArancelImpuesto2s = new HashSet<ArancelImpuesto2>();
            ArticuloCompra2s = new HashSet<ArticuloCompra2>();
            ExcepcionArancelPai2s = new HashSet<ExcepcionArancelPai2>();
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

        public virtual ICollection<ArancelImpuesto2> ArancelImpuesto2s { get; set; }
        public virtual ICollection<ArticuloCompra2> ArticuloCompra2s { get; set; }
        public virtual ICollection<ExcepcionArancelPai2> ExcepcionArancelPai2s { get; set; }
    }
}
