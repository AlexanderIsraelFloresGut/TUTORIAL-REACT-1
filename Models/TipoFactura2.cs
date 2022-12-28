using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class TipoFactura2
    {
        public TipoFactura2()
        {
            DocumentosCc2s = new HashSet<DocumentosCc2>();
            Factura2s = new HashSet<Factura2>();
            Pedido2s = new HashSet<Pedido2>();
        }

        public string Codigo { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public string? Factura { get; set; }
        public string? Boleta { get; set; }
        public string? LiquidacionCompra { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual ICollection<DocumentosCc2> DocumentosCc2s { get; set; }
        public virtual ICollection<Factura2> Factura2s { get; set; }
        public virtual ICollection<Pedido2> Pedido2s { get; set; }
    }
}
