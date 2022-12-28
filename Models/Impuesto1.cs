using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class Impuesto1
    {
        public Impuesto1()
        {
            Articulo1s = new HashSet<Articulo1>();
            ArticuloCompra1s = new HashSet<ArticuloCompra1>();
            Cliente1s = new HashSet<Cliente1>();
            DesgImpuestoCh1s = new HashSet<DesgImpuestoCh1>();
            DiferidosImpuesto1s = new HashSet<DiferidosImpuesto1>();
            DocsSoporte1s = new HashSet<DocsSoporte1>();
            DocumentosCc1s = new HashSet<DocumentosCc1>();
            DocumentosCp1s = new HashSet<DocumentosCp1>();
            FacturaLinea1s = new HashSet<FacturaLinea1>();
            ImpuestoActivo1s = new HashSet<ImpuestoActivo1>();
            MovBanco1s = new HashSet<MovBanco1>();
            Proveedor1CodigoImpuestoNavigations = new HashSet<Proveedor1>();
            Proveedor1ImpuestoRentaNavigations = new HashSet<Proveedor1>();
        }

        public string Impuesto { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public decimal Impuesto11 { get; set; }
        public decimal Impuesto2 { get; set; }
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
        public string? CodImp1 { get; set; }
        public string? CodImp2 { get; set; }
        public string? UsaImpuesto1Cantidad { get; set; }
        public decimal? Impuesto1Cantidad { get; set; }
        public string? UCodigoPorcentaje1 { get; set; }
        public string? UCodigoPorcentaje2 { get; set; }

        public virtual CentroCuentum1? Ct { get; set; }
        public virtual CentroCuentum1? Ct1 { get; set; }
        public virtual CentroCuentum1? Ct2 { get; set; }
        public virtual CentroCuentum1? Ct3 { get; set; }
        public virtual CentroCuentum1? Ct4 { get; set; }
        public virtual CentroCuentum1? Ct5 { get; set; }
        public virtual CentroCuentum1? Ct6 { get; set; }
        public virtual CentroCuentum1? Ct7 { get; set; }
        public virtual CentroCuentum1? Ct8 { get; set; }
        public virtual CentroCuentum1? CtNavigation { get; set; }
        public virtual TipoImpuesto1? TipoImpuesto1Navigation { get; set; }
        public virtual TipoImpuesto1? TipoImpuesto2Navigation { get; set; }
        public virtual ICollection<Articulo1> Articulo1s { get; set; }
        public virtual ICollection<ArticuloCompra1> ArticuloCompra1s { get; set; }
        public virtual ICollection<Cliente1> Cliente1s { get; set; }
        public virtual ICollection<DesgImpuestoCh1> DesgImpuestoCh1s { get; set; }
        public virtual ICollection<DiferidosImpuesto1> DiferidosImpuesto1s { get; set; }
        public virtual ICollection<DocsSoporte1> DocsSoporte1s { get; set; }
        public virtual ICollection<DocumentosCc1> DocumentosCc1s { get; set; }
        public virtual ICollection<DocumentosCp1> DocumentosCp1s { get; set; }
        public virtual ICollection<FacturaLinea1> FacturaLinea1s { get; set; }
        public virtual ICollection<ImpuestoActivo1> ImpuestoActivo1s { get; set; }
        public virtual ICollection<MovBanco1> MovBanco1s { get; set; }
        public virtual ICollection<Proveedor1> Proveedor1CodigoImpuestoNavigations { get; set; }
        public virtual ICollection<Proveedor1> Proveedor1ImpuestoRentaNavigations { get; set; }
    }
}
