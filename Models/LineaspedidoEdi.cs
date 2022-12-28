using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class LineaspedidoEdi
    {
        public string Numeroorden { get; set; } = null!;
        public string GlnComprador { get; set; } = null!;
        public short Numerolinea { get; set; }
        public string? Pedido { get; set; }
        public string? Dun14 { get; set; }
        public decimal Preciounitario { get; set; }
        public decimal CantidadPedida { get; set; }
        public decimal CantidadDespachada { get; set; }
        public decimal CantidadRecibida { get; set; }
        public decimal MontoImpuesto1 { get; set; }
        public decimal PorcentajeImpuesto1 { get; set; }
        public decimal MontoImpuesto2 { get; set; }
        public decimal PorcentajeImpuesto2 { get; set; }
        public decimal MontoDescuento1 { get; set; }
        public decimal PorcentajeDescuento1 { get; set; }
        public decimal MontoDescuento2 { get; set; }
        public decimal PorcentajeDescuento2 { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual PedidoEdi PedidoEdi { get; set; } = null!;
    }
}
