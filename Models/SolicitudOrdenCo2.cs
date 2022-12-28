using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class SolicitudOrdenCo2
    {
        public string SolicitudOc { get; set; } = null!;
        public short SolicitudOcLinea { get; set; }
        public string OrdenCompra { get; set; } = null!;
        public short OrdenCompraLinea { get; set; }
        public decimal Cantidad { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual OrdenCompraLinea2 OrdenCompraNavigation { get; set; } = null!;
        public virtual SolicitudOcLinea2 SolicitudOcNavigation { get; set; } = null!;
    }
}
