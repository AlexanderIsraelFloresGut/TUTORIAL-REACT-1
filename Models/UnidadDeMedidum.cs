using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class UnidadDeMedidum
    {
        public UnidadDeMedidum()
        {
            ArtUndDistribucis = new HashSet<ArtUndDistribuci>();
            ArticuloUnidadAlmacenNavigations = new HashSet<Articulo>();
            ArticuloUnidadEmpaqueNavigations = new HashSet<Articulo>();
            ArticuloUnidadVentaNavigations = new HashSet<Articulo>();
            Clasificacions = new HashSet<Clasificacion>();
            EmbarqueLineas = new HashSet<EmbarqueLinea>();
            FacturaLineas = new HashSet<FacturaLinea>();
            LineaDocInvs = new HashSet<LineaDocInv>();
            OpOperDetDespers = new HashSet<OpOperDetDesper>();
            OpOperacions = new HashSet<OpOperacion>();
            OrdenCompraLineas = new HashSet<OrdenCompraLinea>();
            PedidoLineas = new HashSet<PedidoLinea>();
            SolicitudOcLineas = new HashSet<SolicitudOcLinea>();
            TransaccionInvs = new HashSet<TransaccionInv>();
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

        public virtual ICollection<ArtUndDistribuci> ArtUndDistribucis { get; set; }
        public virtual ICollection<Articulo> ArticuloUnidadAlmacenNavigations { get; set; }
        public virtual ICollection<Articulo> ArticuloUnidadEmpaqueNavigations { get; set; }
        public virtual ICollection<Articulo> ArticuloUnidadVentaNavigations { get; set; }
        public virtual ICollection<Clasificacion> Clasificacions { get; set; }
        public virtual ICollection<EmbarqueLinea> EmbarqueLineas { get; set; }
        public virtual ICollection<FacturaLinea> FacturaLineas { get; set; }
        public virtual ICollection<LineaDocInv> LineaDocInvs { get; set; }
        public virtual ICollection<OpOperDetDesper> OpOperDetDespers { get; set; }
        public virtual ICollection<OpOperacion> OpOperacions { get; set; }
        public virtual ICollection<OrdenCompraLinea> OrdenCompraLineas { get; set; }
        public virtual ICollection<PedidoLinea> PedidoLineas { get; set; }
        public virtual ICollection<SolicitudOcLinea> SolicitudOcLineas { get; set; }
        public virtual ICollection<TransaccionInv> TransaccionInvs { get; set; }
    }
}
