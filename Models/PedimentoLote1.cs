using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class PedimentoLote1
    {
        public string Pedimento { get; set; } = null!;
        public string Articulo { get; set; } = null!;
        public string Lote { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual Lote1 Lote1 { get; set; } = null!;
        public virtual Pedimento1 PedimentoNavigation { get; set; } = null!;
    }
}
