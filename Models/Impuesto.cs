using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class Impuesto
    {
        public Impuesto()
        {
            ArticuloCompras = new HashSet<ArticuloCompra>();
            Articulos = new HashSet<Articulo>();
            Clientes = new HashSet<Cliente>();
            DesgImpuestoChes = new HashSet<DesgImpuestoCh>();
            DiferidosImpuestos = new HashSet<DiferidosImpuesto>();
            DocsSoportes = new HashSet<DocsSoporte>();
            DocumentosCcs = new HashSet<DocumentosCc>();
            DocumentosCps = new HashSet<DocumentosCp>();
            ImpuestoActivos = new HashSet<ImpuestoActivo>();
            MovBancos = new HashSet<MovBanco>();
            Proveedors = new HashSet<Proveedor>();
        }

        public string Impuesto1 { get; set; } = null!;
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

        public virtual CentroCuentum? Ct { get; set; }
        public virtual CentroCuentum? Ct1 { get; set; }
        public virtual CentroCuentum? Ct2 { get; set; }
        public virtual CentroCuentum? Ct3 { get; set; }
        public virtual CentroCuentum? Ct4 { get; set; }
        public virtual CentroCuentum? Ct5 { get; set; }
        public virtual CentroCuentum? Ct6 { get; set; }
        public virtual CentroCuentum? Ct7 { get; set; }
        public virtual CentroCuentum? Ct8 { get; set; }
        public virtual CentroCuentum? CtNavigation { get; set; }
        public virtual TipoImpuesto? TipoImpuesto1Navigation { get; set; }
        public virtual TipoImpuesto? TipoImpuesto2Navigation { get; set; }
        public virtual ICollection<ArticuloCompra> ArticuloCompras { get; set; }
        public virtual ICollection<Articulo> Articulos { get; set; }
        public virtual ICollection<Cliente> Clientes { get; set; }
        public virtual ICollection<DesgImpuestoCh> DesgImpuestoChes { get; set; }
        public virtual ICollection<DiferidosImpuesto> DiferidosImpuestos { get; set; }
        public virtual ICollection<DocsSoporte> DocsSoportes { get; set; }
        public virtual ICollection<DocumentosCc> DocumentosCcs { get; set; }
        public virtual ICollection<DocumentosCp> DocumentosCps { get; set; }
        public virtual ICollection<ImpuestoActivo> ImpuestoActivos { get; set; }
        public virtual ICollection<MovBanco> MovBancos { get; set; }
        public virtual ICollection<Proveedor> Proveedors { get; set; }
    }
}
