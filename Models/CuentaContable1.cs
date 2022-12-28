using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class CuentaContable1
    {
        public CuentaContable1()
        {
            CentroConcepto1CuentaContableNavigations = new HashSet<CentroConcepto1>();
            CentroConcepto1CuentaContraNavigations = new HashSet<CentroConcepto1>();
            CentroCuentum1s = new HashSet<CentroCuentum1>();
            CtaAjusteInfl1ContraCtaAjusteNavigations = new HashSet<CtaAjusteInfl1>();
            CtaAjusteInfl1CtaAjusteNavigations = new HashSet<CtaAjusteInfl1>();
            CuentaDepreciacio1CtaDeprAiCNavigations = new HashSet<CuentaDepreciacio1>();
            CuentaDepreciacio1CtaDeprAiFNavigations = new HashSet<CuentaDepreciacio1>();
            CuentaDepreciacio1CtaDeprDesmantelaCNavigations = new HashSet<CuentaDepreciacio1>();
            CuentaDepreciacio1CtaDeprDesmantelaFNavigations = new HashSet<CuentaDepreciacio1>();
            CuentaDepreciacio1CtaDeprNormalCNavigations = new HashSet<CuentaDepreciacio1>();
            CuentaDepreciacio1CtaDeprNormalNavigations = new HashSet<CuentaDepreciacio1>();
            CuentaDepreciacio1CtaDeprRevalCNavigations = new HashSet<CuentaDepreciacio1>();
            CuentaDepreciacio1CtaDeprRevalNavigations = new HashSet<CuentaDepreciacio1>();
            CuentaSeccion1s = new HashSet<CuentaSeccion1>();
            FacturaLinea1s = new HashSet<FacturaLinea1>();
            PedidoLinea1s = new HashSet<PedidoLinea1>();
            RatiosCuenta1s = new HashSet<RatiosCuenta1>();
            TipoActivo1CtaAiDeprecCNavigations = new HashSet<TipoActivo1>();
            TipoActivo1CtaAiDeprecNavigations = new HashSet<TipoActivo1>();
            TipoActivo1CtaAjuInflacCNavigations = new HashSet<TipoActivo1>();
            TipoActivo1CtaAjuInflacNavigations = new HashSet<TipoActivo1>();
            TipoActivo1CtaDeprDesmanCNavigations = new HashSet<TipoActivo1>();
            TipoActivo1CtaDeprDesmanFNavigations = new HashSet<TipoActivo1>();
            TipoActivo1CtaDesmanCNavigations = new HashSet<TipoActivo1>();
            TipoActivo1CtaDesmanFNavigations = new HashSet<TipoActivo1>();
            TipoActivo1CtaDeterioroCNavigations = new HashSet<TipoActivo1>();
            TipoActivo1CtaDeterioroFNavigations = new HashSet<TipoActivo1>();
            TipoActivo1CtaGastoDeterioroCNavigations = new HashSet<TipoActivo1>();
            TipoActivo1CtaGastoDeterioroFNavigations = new HashSet<TipoActivo1>();
        }

        public string CuentaContable { get; set; } = null!;
        public string? SeccionCuenta { get; set; }
        public string? Unidad { get; set; }
        public string Descripcion { get; set; } = null!;
        public string Tipo { get; set; } = null!;
        public string TipoDetallado { get; set; } = null!;
        public string TipoOaf { get; set; } = null!;
        public string SaldoNormal { get; set; } = null!;
        public string Conversion { get; set; } = null!;
        public string TipoCambio { get; set; } = null!;
        public string AceptaDatos { get; set; } = null!;
        public string Consolida { get; set; } = null!;
        public string UsaCentroCosto { get; set; } = null!;
        public string? Notas { get; set; }
        public string Usuario { get; set; } = null!;
        public DateTime FechaHora { get; set; }
        public string UsuarioUltMod { get; set; } = null!;
        public DateTime FchHoraUltMod { get; set; }
        public string AceptaUnidades { get; set; } = null!;
        public string UsoRestringido { get; set; } = null!;
        public string? OrigenConversion { get; set; }
        public string ValidaPresupCr { get; set; } = null!;
        public string? CuentaIfrs { get; set; }
        public string UsaContaElectro { get; set; } = null!;
        public string Version { get; set; } = null!;
        public DateTime? FechaIniCe { get; set; }
        public DateTime? FechaFinCe { get; set; }
        public string? CodAgrupador { get; set; }
        public string? DescCodAgrup { get; set; }
        public string? SubCtaDe { get; set; }
        public string? DescSubCta { get; set; }
        public string? Nivel { get; set; }
        public string? DescripcionIfrs { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
        public string? UUdf { get; set; }
        public string ManejaTercero { get; set; } = null!;

        public virtual SeccionCuentum1? SeccionCuentaNavigation { get; set; }
        public virtual TipoCambio1 TipoCambioNavigation { get; set; } = null!;
        public virtual Unidad1? UnidadNavigation { get; set; }
        public virtual Usuario2 UsuarioNavigation { get; set; } = null!;
        public virtual Usuario2 UsuarioUltModNavigation { get; set; } = null!;
        public virtual CtaAjusteInfl1 CtaAjusteInfl1CtaAjustableNavigation { get; set; } = null!;
        public virtual ICollection<CentroConcepto1> CentroConcepto1CuentaContableNavigations { get; set; }
        public virtual ICollection<CentroConcepto1> CentroConcepto1CuentaContraNavigations { get; set; }
        public virtual ICollection<CentroCuentum1> CentroCuentum1s { get; set; }
        public virtual ICollection<CtaAjusteInfl1> CtaAjusteInfl1ContraCtaAjusteNavigations { get; set; }
        public virtual ICollection<CtaAjusteInfl1> CtaAjusteInfl1CtaAjusteNavigations { get; set; }
        public virtual ICollection<CuentaDepreciacio1> CuentaDepreciacio1CtaDeprAiCNavigations { get; set; }
        public virtual ICollection<CuentaDepreciacio1> CuentaDepreciacio1CtaDeprAiFNavigations { get; set; }
        public virtual ICollection<CuentaDepreciacio1> CuentaDepreciacio1CtaDeprDesmantelaCNavigations { get; set; }
        public virtual ICollection<CuentaDepreciacio1> CuentaDepreciacio1CtaDeprDesmantelaFNavigations { get; set; }
        public virtual ICollection<CuentaDepreciacio1> CuentaDepreciacio1CtaDeprNormalCNavigations { get; set; }
        public virtual ICollection<CuentaDepreciacio1> CuentaDepreciacio1CtaDeprNormalNavigations { get; set; }
        public virtual ICollection<CuentaDepreciacio1> CuentaDepreciacio1CtaDeprRevalCNavigations { get; set; }
        public virtual ICollection<CuentaDepreciacio1> CuentaDepreciacio1CtaDeprRevalNavigations { get; set; }
        public virtual ICollection<CuentaSeccion1> CuentaSeccion1s { get; set; }
        public virtual ICollection<FacturaLinea1> FacturaLinea1s { get; set; }
        public virtual ICollection<PedidoLinea1> PedidoLinea1s { get; set; }
        public virtual ICollection<RatiosCuenta1> RatiosCuenta1s { get; set; }
        public virtual ICollection<TipoActivo1> TipoActivo1CtaAiDeprecCNavigations { get; set; }
        public virtual ICollection<TipoActivo1> TipoActivo1CtaAiDeprecNavigations { get; set; }
        public virtual ICollection<TipoActivo1> TipoActivo1CtaAjuInflacCNavigations { get; set; }
        public virtual ICollection<TipoActivo1> TipoActivo1CtaAjuInflacNavigations { get; set; }
        public virtual ICollection<TipoActivo1> TipoActivo1CtaDeprDesmanCNavigations { get; set; }
        public virtual ICollection<TipoActivo1> TipoActivo1CtaDeprDesmanFNavigations { get; set; }
        public virtual ICollection<TipoActivo1> TipoActivo1CtaDesmanCNavigations { get; set; }
        public virtual ICollection<TipoActivo1> TipoActivo1CtaDesmanFNavigations { get; set; }
        public virtual ICollection<TipoActivo1> TipoActivo1CtaDeterioroCNavigations { get; set; }
        public virtual ICollection<TipoActivo1> TipoActivo1CtaDeterioroFNavigations { get; set; }
        public virtual ICollection<TipoActivo1> TipoActivo1CtaGastoDeterioroCNavigations { get; set; }
        public virtual ICollection<TipoActivo1> TipoActivo1CtaGastoDeterioroFNavigations { get; set; }
    }
}
