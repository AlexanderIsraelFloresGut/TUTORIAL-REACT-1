using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class TipoFactura
    {
        public TipoFactura()
        {
            DocumentosCcs = new HashSet<DocumentosCc>();
            Facturas = new HashSet<Factura>();
            Pedidos = new HashSet<Pedido>();
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

        public virtual ICollection<DocumentosCc> DocumentosCcs { get; set; }
        public virtual ICollection<Factura> Facturas { get; set; }
        public virtual ICollection<Pedido> Pedidos { get; set; }
    }
}
