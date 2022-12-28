using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class TipoPago2
    {
        public TipoPago2()
        {
            Despacho2s = new HashSet<Despacho2>();
            Devolucion2s = new HashSet<Devolucion2>();
            DocsSoporte2s = new HashSet<DocsSoporte2>();
            DocumentoEmbarque2s = new HashSet<DocumentoEmbarque2>();
            DocumentosCc2s = new HashSet<DocumentosCc2>();
            DocumentosCp2s = new HashSet<DocumentosCp2>();
            Factura2s = new HashSet<Factura2>();
            LineaDocInv2s = new HashSet<LineaDocInv2>();
            MatrizOperInventario2s = new HashSet<MatrizOperInventario2>();
            Pedido2s = new HashSet<Pedido2>();
            SubtipoDocCc2s = new HashSet<SubtipoDocCc2>();
            SubtipoDocCp2s = new HashSet<SubtipoDocCp2>();
            TransaccionInv2s = new HashSet<TransaccionInv2>();
        }

        public string TipoPago { get; set; } = null!;
        public string? Descripcion { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual ICollection<Despacho2> Despacho2s { get; set; }
        public virtual ICollection<Devolucion2> Devolucion2s { get; set; }
        public virtual ICollection<DocsSoporte2> DocsSoporte2s { get; set; }
        public virtual ICollection<DocumentoEmbarque2> DocumentoEmbarque2s { get; set; }
        public virtual ICollection<DocumentosCc2> DocumentosCc2s { get; set; }
        public virtual ICollection<DocumentosCp2> DocumentosCp2s { get; set; }
        public virtual ICollection<Factura2> Factura2s { get; set; }
        public virtual ICollection<LineaDocInv2> LineaDocInv2s { get; set; }
        public virtual ICollection<MatrizOperInventario2> MatrizOperInventario2s { get; set; }
        public virtual ICollection<Pedido2> Pedido2s { get; set; }
        public virtual ICollection<SubtipoDocCc2> SubtipoDocCc2s { get; set; }
        public virtual ICollection<SubtipoDocCp2> SubtipoDocCp2s { get; set; }
        public virtual ICollection<TransaccionInv2> TransaccionInv2s { get; set; }
    }
}
