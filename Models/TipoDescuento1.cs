using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class TipoDescuento1
    {
        public TipoDescuento1()
        {
            DocumentosCc1s = new HashSet<DocumentosCc1>();
            Factura1s = new HashSet<Factura1>();
            FacturaLinea1s = new HashSet<FacturaLinea1>();
            Pedido1s = new HashSet<Pedido1>();
            PedidoLinea1s = new HashSet<PedidoLinea1>();
        }

        public string Codigo { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public string Nivel { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual ICollection<DocumentosCc1> DocumentosCc1s { get; set; }
        public virtual ICollection<Factura1> Factura1s { get; set; }
        public virtual ICollection<FacturaLinea1> FacturaLinea1s { get; set; }
        public virtual ICollection<Pedido1> Pedido1s { get; set; }
        public virtual ICollection<PedidoLinea1> PedidoLinea1s { get; set; }
    }
}
