using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class OrdenMovPresLinea
    {
        public string OrdenCompra { get; set; } = null!;
        public short OrdenCompraLinea { get; set; }
        public int Numero { get; set; }
        public int LineaCr { get; set; }
        public string ActualizadoBd { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual OrdenMovPre OrdenMovPre { get; set; } = null!;
    }
}
