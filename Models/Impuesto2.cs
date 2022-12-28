using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class Impuesto2
    {
        public Impuesto2()
        {
            Articulo2s = new HashSet<Articulo2>();
            ArticuloCompra2s = new HashSet<ArticuloCompra2>();
            Cliente2s = new HashSet<Cliente2>();
            DesgImpuestoCh2s = new HashSet<DesgImpuestoCh2>();
            DiferidosImpuesto2s = new HashSet<DiferidosImpuesto2>();
            DocsSoporte2s = new HashSet<DocsSoporte2>();
            DocumentosCc2s = new HashSet<DocumentosCc2>();
            DocumentosCp2s = new HashSet<DocumentosCp2>();
            ImpuestoActivo2s = new HashSet<ImpuestoActivo2>();
            MovBanco2s = new HashSet<MovBanco2>();
            Proveedor2s = new HashSet<Proveedor2>();
        }

        public string Impuesto { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public decimal Impuesto1 { get; set; }
        public decimal Impuesto21 { get; set; }
        public string? UsaImpuesto2Cantidad { get; set; }
        public decimal? Impuesto2Cantidad { get; set; }
        public string? CtrImp1Gen { get; set; }
        public string? CtaImp1Gen { get; set; }
        public string? CtrImp2Gen { get; set; }
        public string? CtaImp2Gen { get; set; }
        public string? CtrImp1GenVts { get; set; }
        public string? CtaImp1GenVts { get; set; }
        public string? CtrImp2GenVts { get; set; }
        public string? CtaImp2GenVts { get; set; }
        public string? CtrImp1DescCmps { get; set; }
        public string? CtaImp1DescCmps { get; set; }
        public string? CtrImp2DescCmps { get; set; }
        public string? CtaImp2DescCmps { get; set; }
        public string? CtrImp1DevCmps { get; set; }
        public string? CtaImp1DevCmps { get; set; }
        public string? CtrImp2DevCmps { get; set; }
        public string? CtaImp2DevCmps { get; set; }
        public string? CtrImp1DevVts { get; set; }
        public string? CtaImp1DevVts { get; set; }
        public string? CtrImp2DevVts { get; set; }
        public string? CtaImp2DevVts { get; set; }
        public string TipoContabImp1 { get; set; } = null!;
        public string TipoContabImp2 { get; set; } = null!;
        public string ContabDevImp1 { get; set; } = null!;
        public string ContabDevImp2 { get; set; } = null!;
        public string CalculoImp2 { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
        public string? UImpuesto1Sat { get; set; }
        public string? UImpuesto2Sat { get; set; }
        public string? TipoImpuesto1 { get; set; }
        public string? TipoImpuesto2 { get; set; }
        public string? UImpuesto { get; set; }
        public string? UImpuesto2 { get; set; }
        public string? TipoTarifa1 { get; set; }
        public string? TipoTarifa2 { get; set; }
        public string Estado { get; set; } = null!;
        public string UImpuestoExcluido { get; set; } = null!;
        public string EsBienCubierto { get; set; } = null!;

        public virtual CentroCuentum2? Ct { get; set; }
        public virtual CentroCuentum2? Ct1 { get; set; }
        public virtual CentroCuentum2? Ct2 { get; set; }
        public virtual CentroCuentum2? Ct3 { get; set; }
        public virtual CentroCuentum2? Ct4 { get; set; }
        public virtual CentroCuentum2? Ct5 { get; set; }
        public virtual CentroCuentum2? Ct6 { get; set; }
        public virtual CentroCuentum2? Ct7 { get; set; }
        public virtual CentroCuentum2? Ct8 { get; set; }
        public virtual CentroCuentum2? CtNavigation { get; set; }
        public virtual TipoImpuesto2? TipoImpuesto1Navigation { get; set; }
        public virtual TipoImpuesto2? TipoImpuesto2Navigation { get; set; }
        public virtual ICollection<Articulo2> Articulo2s { get; set; }
        public virtual ICollection<ArticuloCompra2> ArticuloCompra2s { get; set; }
        public virtual ICollection<Cliente2> Cliente2s { get; set; }
        public virtual ICollection<DesgImpuestoCh2> DesgImpuestoCh2s { get; set; }
        public virtual ICollection<DiferidosImpuesto2> DiferidosImpuesto2s { get; set; }
        public virtual ICollection<DocsSoporte2> DocsSoporte2s { get; set; }
        public virtual ICollection<DocumentosCc2> DocumentosCc2s { get; set; }
        public virtual ICollection<DocumentosCp2> DocumentosCp2s { get; set; }
        public virtual ICollection<ImpuestoActivo2> ImpuestoActivo2s { get; set; }
        public virtual ICollection<MovBanco2> MovBanco2s { get; set; }
        public virtual ICollection<Proveedor2> Proveedor2s { get; set; }
    }
}
