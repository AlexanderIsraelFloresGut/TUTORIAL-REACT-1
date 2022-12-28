using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class PedidoSolicitudLinea
    {
        public string Pedido { get; set; } = null!;
        public short PedidoLinea { get; set; }
        public string SolicitudOc { get; set; } = null!;
        public short SolicitudOcLinea { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
    }
}
