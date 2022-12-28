using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class MonedaPedBackord
    {
        public string Pedido { get; set; } = null!;
        public string? MonedaFactura { get; set; }
        public string? MonedaRemision { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual Pedido PedidoNavigation { get; set; } = null!;
    }
}
