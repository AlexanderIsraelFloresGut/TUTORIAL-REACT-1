using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class TipoPago1
    {
        public TipoPago1()
        {
            Despacho1s = new HashSet<Despacho1>();
            Devolucion1s = new HashSet<Devolucion1>();
            DocsSoporte1s = new HashSet<DocsSoporte1>();
            DocumentoEmbarque1s = new HashSet<DocumentoEmbarque1>();
            DocumentosCc1s = new HashSet<DocumentosCc1>();
            DocumentosCp1s = new HashSet<DocumentosCp1>();
            Factura1s = new HashSet<Factura1>();
            LineaDocInv1s = new HashSet<LineaDocInv1>();
            MatrizOperInventario1s = new HashSet<MatrizOperInventario1>();
            Pedido1s = new HashSet<Pedido1>();
            SubtipoDocCc1s = new HashSet<SubtipoDocCc1>();
            SubtipoDocCp1s = new HashSet<SubtipoDocCp1>();
            TransaccionInv1s = new HashSet<TransaccionInv1>();
        }

        public string TipoPago { get; set; } = null!;
        public string? Descripcion { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual ICollection<Despacho1> Despacho1s { get; set; }
        public virtual ICollection<Devolucion1> Devolucion1s { get; set; }
        public virtual ICollection<DocsSoporte1> DocsSoporte1s { get; set; }
        public virtual ICollection<DocumentoEmbarque1> DocumentoEmbarque1s { get; set; }
        public virtual ICollection<DocumentosCc1> DocumentosCc1s { get; set; }
        public virtual ICollection<DocumentosCp1> DocumentosCp1s { get; set; }
        public virtual ICollection<Factura1> Factura1s { get; set; }
        public virtual ICollection<LineaDocInv1> LineaDocInv1s { get; set; }
        public virtual ICollection<MatrizOperInventario1> MatrizOperInventario1s { get; set; }
        public virtual ICollection<Pedido1> Pedido1s { get; set; }
        public virtual ICollection<SubtipoDocCc1> SubtipoDocCc1s { get; set; }
        public virtual ICollection<SubtipoDocCp1> SubtipoDocCp1s { get; set; }
        public virtual ICollection<TransaccionInv1> TransaccionInv1s { get; set; }
    }
}
