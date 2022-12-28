using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class TipoDescuento2
    {
        public TipoDescuento2()
        {
            DocumentosCc2s = new HashSet<DocumentosCc2>();
            Factura2s = new HashSet<Factura2>();
            FacturaLinea2s = new HashSet<FacturaLinea2>();
            Pedido2s = new HashSet<Pedido2>();
            PedidoLinea2s = new HashSet<PedidoLinea2>();
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

        public virtual ICollection<DocumentosCc2> DocumentosCc2s { get; set; }
        public virtual ICollection<Factura2> Factura2s { get; set; }
        public virtual ICollection<FacturaLinea2> FacturaLinea2s { get; set; }
        public virtual ICollection<Pedido2> Pedido2s { get; set; }
        public virtual ICollection<PedidoLinea2> PedidoLinea2s { get; set; }
    }
}
