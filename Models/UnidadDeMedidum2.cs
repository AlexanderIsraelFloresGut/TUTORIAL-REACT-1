using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class UnidadDeMedidum2
    {
        public UnidadDeMedidum2()
        {
            ArtUndDistribuci2s = new HashSet<ArtUndDistribuci2>();
            Articulo2UnidadAlmacenNavigations = new HashSet<Articulo2>();
            Articulo2UnidadEmpaqueNavigations = new HashSet<Articulo2>();
            Articulo2UnidadVentaNavigations = new HashSet<Articulo2>();
            Clasificacion2s = new HashSet<Clasificacion2>();
            EmbarqueLinea2s = new HashSet<EmbarqueLinea2>();
            FacturaLinea2s = new HashSet<FacturaLinea2>();
            LineaDocInv2s = new HashSet<LineaDocInv2>();
            OpOperDetDesper2s = new HashSet<OpOperDetDesper2>();
            OpOperacion2s = new HashSet<OpOperacion2>();
            OrdenCompraLinea2s = new HashSet<OrdenCompraLinea2>();
            PedidoLinea2s = new HashSet<PedidoLinea2>();
            SolicitudOcLinea2s = new HashSet<SolicitudOcLinea2>();
            TransaccionInv2s = new HashSet<TransaccionInv2>();
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

        public virtual ICollection<ArtUndDistribuci2> ArtUndDistribuci2s { get; set; }
        public virtual ICollection<Articulo2> Articulo2UnidadAlmacenNavigations { get; set; }
        public virtual ICollection<Articulo2> Articulo2UnidadEmpaqueNavigations { get; set; }
        public virtual ICollection<Articulo2> Articulo2UnidadVentaNavigations { get; set; }
        public virtual ICollection<Clasificacion2> Clasificacion2s { get; set; }
        public virtual ICollection<EmbarqueLinea2> EmbarqueLinea2s { get; set; }
        public virtual ICollection<FacturaLinea2> FacturaLinea2s { get; set; }
        public virtual ICollection<LineaDocInv2> LineaDocInv2s { get; set; }
        public virtual ICollection<OpOperDetDesper2> OpOperDetDesper2s { get; set; }
        public virtual ICollection<OpOperacion2> OpOperacion2s { get; set; }
        public virtual ICollection<OrdenCompraLinea2> OrdenCompraLinea2s { get; set; }
        public virtual ICollection<PedidoLinea2> PedidoLinea2s { get; set; }
        public virtual ICollection<SolicitudOcLinea2> SolicitudOcLinea2s { get; set; }
        public virtual ICollection<TransaccionInv2> TransaccionInv2s { get; set; }
    }
}
