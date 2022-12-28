using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class ImpuestoDonde1
    {
        public string ImpuestoCompra { get; set; } = null!;
        public string? FormulaDonde { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual ImpuestoCompra1 ImpuestoCompraNavigation { get; set; } = null!;
    }
}
