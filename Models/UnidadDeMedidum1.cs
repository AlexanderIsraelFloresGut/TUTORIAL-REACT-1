using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class UnidadDeMedidum1
    {
        public UnidadDeMedidum1()
        {
            ArtUndDistribuci1s = new HashSet<ArtUndDistribuci1>();
            Articulo1UnidadAlmacenNavigations = new HashSet<Articulo1>();
            Articulo1UnidadEmpaqueNavigations = new HashSet<Articulo1>();
            Articulo1UnidadVentaNavigations = new HashSet<Articulo1>();
            Clasificacion1s = new HashSet<Clasificacion1>();
            EmbarqueLinea1s = new HashSet<EmbarqueLinea1>();
            FacturaLinea1s = new HashSet<FacturaLinea1>();
            LineaDocInv1s = new HashSet<LineaDocInv1>();
            OpOperDetDesper1s = new HashSet<OpOperDetDesper1>();
            OpOperacion1s = new HashSet<OpOperacion1>();
            OrdenCompraLinea1s = new HashSet<OrdenCompraLinea1>();
            PedidoLinea1s = new HashSet<PedidoLinea1>();
            SolicitudOcLinea1s = new HashSet<SolicitudOcLinea1>();
            TransaccionInv1s = new HashSet<TransaccionInv1>();
        }

        public string UnidadMedida { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
        public string? UFeunidad { get; set; }

        public virtual ICollection<ArtUndDistribuci1> ArtUndDistribuci1s { get; set; }
        public virtual ICollection<Articulo1> Articulo1UnidadAlmacenNavigations { get; set; }
        public virtual ICollection<Articulo1> Articulo1UnidadEmpaqueNavigations { get; set; }
        public virtual ICollection<Articulo1> Articulo1UnidadVentaNavigations { get; set; }
        public virtual ICollection<Clasificacion1> Clasificacion1s { get; set; }
        public virtual ICollection<EmbarqueLinea1> EmbarqueLinea1s { get; set; }
        public virtual ICollection<FacturaLinea1> FacturaLinea1s { get; set; }
        public virtual ICollection<LineaDocInv1> LineaDocInv1s { get; set; }
        public virtual ICollection<OpOperDetDesper1> OpOperDetDesper1s { get; set; }
        public virtual ICollection<OpOperacion1> OpOperacion1s { get; set; }
        public virtual ICollection<OrdenCompraLinea1> OrdenCompraLinea1s { get; set; }
        public virtual ICollection<PedidoLinea1> PedidoLinea1s { get; set; }
        public virtual ICollection<SolicitudOcLinea1> SolicitudOcLinea1s { get; set; }
        public virtual ICollection<TransaccionInv1> TransaccionInv1s { get; set; }
    }
}
