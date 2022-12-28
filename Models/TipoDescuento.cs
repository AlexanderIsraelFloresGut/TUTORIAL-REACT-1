using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class TipoDescuento
    {
        public TipoDescuento()
        {
            DocumentosCcs = new HashSet<DocumentosCc>();
            FacturaLineas = new HashSet<FacturaLinea>();
            Facturas = new HashSet<Factura>();
            PedidoLineas = new HashSet<PedidoLinea>();
            Pedidos = new HashSet<Pedido>();
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

        public virtual ICollection<DocumentosCc> DocumentosCcs { get; set; }
        public virtual ICollection<FacturaLinea> FacturaLineas { get; set; }
        public virtual ICollection<Factura> Facturas { get; set; }
        public virtual ICollection<PedidoLinea> PedidoLineas { get; set; }
        public virtual ICollection<Pedido> Pedidos { get; set; }
    }
}
