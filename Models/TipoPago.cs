using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class TipoPago
    {
        public TipoPago()
        {
            Despachos = new HashSet<Despacho>();
            Devolucions = new HashSet<Devolucion>();
            DocsSoportes = new HashSet<DocsSoporte>();
            DocumentoEmbarques = new HashSet<DocumentoEmbarque>();
            DocumentosCcs = new HashSet<DocumentosCc>();
            DocumentosCps = new HashSet<DocumentosCp>();
            Facturas = new HashSet<Factura>();
            LineaDocInvs = new HashSet<LineaDocInv>();
            MatrizOperInventarios = new HashSet<MatrizOperInventario>();
            Pedidos = new HashSet<Pedido>();
            SubtipoDocCcs = new HashSet<SubtipoDocCc>();
            SubtipoDocCps = new HashSet<SubtipoDocCp>();
            TransaccionInvs = new HashSet<TransaccionInv>();
        }

        public string TipoPago1 { get; set; } = null!;
        public string? Descripcion { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual ICollection<Despacho> Despachos { get; set; }
        public virtual ICollection<Devolucion> Devolucions { get; set; }
        public virtual ICollection<DocsSoporte> DocsSoportes { get; set; }
        public virtual ICollection<DocumentoEmbarque> DocumentoEmbarques { get; set; }
        public virtual ICollection<DocumentosCc> DocumentosCcs { get; set; }
        public virtual ICollection<DocumentosCp> DocumentosCps { get; set; }
        public virtual ICollection<Factura> Facturas { get; set; }
        public virtual ICollection<LineaDocInv> LineaDocInvs { get; set; }
        public virtual ICollection<MatrizOperInventario> MatrizOperInventarios { get; set; }
        public virtual ICollection<Pedido> Pedidos { get; set; }
        public virtual ICollection<SubtipoDocCc> SubtipoDocCcs { get; set; }
        public virtual ICollection<SubtipoDocCp> SubtipoDocCps { get; set; }
        public virtual ICollection<TransaccionInv> TransaccionInvs { get; set; }
    }
}
