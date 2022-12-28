using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class ExcepcionArancelImp2
    {
        public string CodigoArancel { get; set; } = null!;
        public string Pais { get; set; } = null!;
        public string Tipo { get; set; } = null!;
        public string ImpuestoCompra { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual ExcepcionArancelPai2 ExcepcionArancelPai2 { get; set; } = null!;
        public virtual ImpuestoCompra2 ImpuestoCompraNavigation { get; set; } = null!;
    }
}
