using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class CodigoArancel
    {
        public CodigoArancel()
        {
            ArancelImpuestos = new HashSet<ArancelImpuesto>();
            ArticuloCompras = new HashSet<ArticuloCompra>();
            ExcepcionArancelPais = new HashSet<ExcepcionArancelPai>();
        }

        public string CodigoArancel1 { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public string? Notas { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual ICollection<ArancelImpuesto> ArancelImpuestos { get; set; }
        public virtual ICollection<ArticuloCompra> ArticuloCompras { get; set; }
        public virtual ICollection<ExcepcionArancelPai> ExcepcionArancelPais { get; set; }
    }
}
