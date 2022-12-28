using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class ArancelImpuesto1
    {
        public string CodigoArancel { get; set; } = null!;
        public string ImpuestoCompra { get; set; } = null!;
        public string UtilizadoSiempre { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual CodigoArancel1 CodigoArancelNavigation { get; set; } = null!;
        public virtual ImpuestoCompra1 ImpuestoCompraNavigation { get; set; } = null!;
    }
}
