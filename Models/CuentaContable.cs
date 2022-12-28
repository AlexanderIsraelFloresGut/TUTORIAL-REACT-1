using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class CuentaContable
    {
        public CuentaContable()
        {
            CentroConceptoCuentaContableNavigations = new HashSet<CentroConcepto>();
            CentroConceptoCuentaContraNavigations = new HashSet<CentroConcepto>();
            CentroCuenta = new HashSet<CentroCuentum>();
            CtaAjusteInflContraCtaAjusteNavigations = new HashSet<CtaAjusteInfl>();
            CtaAjusteInflCtaAjusteNavigations = new HashSet<CtaAjusteInfl>();
            CuentaDepreciacioCtaDeprAiCNavigations = new HashSet<CuentaDepreciacio>();
            CuentaDepreciacioCtaDeprAiFNavigations = new HashSet<CuentaDepreciacio>();
            CuentaDepreciacioCtaDeprDesmantelaCNavigations = new HashSet<CuentaDepreciacio>();
            CuentaDepreciacioCtaDeprDesmantelaFNavigations = new HashSet<CuentaDepreciacio>();
            CuentaDepreciacioCtaDeprNormalCNavigations = new HashSet<CuentaDepreciacio>();
            CuentaDepreciacioCtaDeprNormalNavigations = new HashSet<CuentaDepreciacio>();
            CuentaDepreciacioCtaDeprRevalCNavigations = new HashSet<CuentaDepreciacio>();
            CuentaDepreciacioCtaDeprRevalNavigations = new HashSet<CuentaDepreciacio>();
            CuentaSeccions = new HashSet<CuentaSeccion>();
            FacturaLineas = new HashSet<FacturaLinea>();
            PedidoLineas = new HashSet<PedidoLinea>();
            RatiosCuenta = new HashSet<RatiosCuenta>();
            TipoActivoCtaAiDeprecCNavigations = new HashSet<TipoActivo>();
            TipoActivoCtaAiDeprecNavigations = new HashSet<TipoActivo>();
            TipoActivoCtaAjuInflacCNavigations = new HashSet<TipoActivo>();
            TipoActivoCtaAjuInflacNavigations = new HashSet<TipoActivo>();
            TipoActivoCtaDeprDesmanCNavigations = new HashSet<TipoActivo>();
            TipoActivoCtaDeprDesmanFNavigations = new HashSet<TipoActivo>();
            TipoActivoCtaDesmanCNavigations = new HashSet<TipoActivo>();
            TipoActivoCtaDesmanFNavigations = new HashSet<TipoActivo>();
            TipoActivoCtaDeterioroCNavigations = new HashSet<TipoActivo>();
            TipoActivoCtaDeterioroFNavigations = new HashSet<TipoActivo>();
            TipoActivoCtaGastoDeterioroCNavigations = new HashSet<TipoActivo>();
            TipoActivoCtaGastoDeterioroFNavigations = new HashSet<TipoActivo>();
        }

        public string CuentaContable1 { get; set; } = null!;
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
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
        public string? UUdf { get; set; }
        public string? DescripcionIfrs { get; set; }
        public string ManejaTercero { get; set; } = null!;

        public virtual SeccionCuentum? SeccionCuentaNavigation { get; set; }
        public virtual TipoCambio TipoCambioNavigation { get; set; } = null!;
        public virtual Unidad? UnidadNavigation { get; set; }
        public virtual Usuario2 UsuarioNavigation { get; set; } = null!;
        public virtual Usuario2 UsuarioUltModNavigation { get; set; } = null!;
        public virtual CtaAjusteInfl CtaAjusteInflCtaAjustableNavigation { get; set; } = null!;
        public virtual ICollection<CentroConcepto> CentroConceptoCuentaContableNavigations { get; set; }
        public virtual ICollection<CentroConcepto> CentroConceptoCuentaContraNavigations { get; set; }
        public virtual ICollection<CentroCuentum> CentroCuenta { get; set; }
        public virtual ICollection<CtaAjusteInfl> CtaAjusteInflContraCtaAjusteNavigations { get; set; }
        public virtual ICollection<CtaAjusteInfl> CtaAjusteInflCtaAjusteNavigations { get; set; }
        public virtual ICollection<CuentaDepreciacio> CuentaDepreciacioCtaDeprAiCNavigations { get; set; }
        public virtual ICollection<CuentaDepreciacio> CuentaDepreciacioCtaDeprAiFNavigations { get; set; }
        public virtual ICollection<CuentaDepreciacio> CuentaDepreciacioCtaDeprDesmantelaCNavigations { get; set; }
        public virtual ICollection<CuentaDepreciacio> CuentaDepreciacioCtaDeprDesmantelaFNavigations { get; set; }
        public virtual ICollection<CuentaDepreciacio> CuentaDepreciacioCtaDeprNormalCNavigations { get; set; }
        public virtual ICollection<CuentaDepreciacio> CuentaDepreciacioCtaDeprNormalNavigations { get; set; }
        public virtual ICollection<CuentaDepreciacio> CuentaDepreciacioCtaDeprRevalCNavigations { get; set; }
        public virtual ICollection<CuentaDepreciacio> CuentaDepreciacioCtaDeprRevalNavigations { get; set; }
        public virtual ICollection<CuentaSeccion> CuentaSeccions { get; set; }
        public virtual ICollection<FacturaLinea> FacturaLineas { get; set; }
        public virtual ICollection<PedidoLinea> PedidoLineas { get; set; }
        public virtual ICollection<RatiosCuenta> RatiosCuenta { get; set; }
        public virtual ICollection<TipoActivo> TipoActivoCtaAiDeprecCNavigations { get; set; }
        public virtual ICollection<TipoActivo> TipoActivoCtaAiDeprecNavigations { get; set; }
        public virtual ICollection<TipoActivo> TipoActivoCtaAjuInflacCNavigations { get; set; }
        public virtual ICollection<TipoActivo> TipoActivoCtaAjuInflacNavigations { get; set; }
        public virtual ICollection<TipoActivo> TipoActivoCtaDeprDesmanCNavigations { get; set; }
        public virtual ICollection<TipoActivo> TipoActivoCtaDeprDesmanFNavigations { get; set; }
        public virtual ICollection<TipoActivo> TipoActivoCtaDesmanCNavigations { get; set; }
        public virtual ICollection<TipoActivo> TipoActivoCtaDesmanFNavigations { get; set; }
        public virtual ICollection<TipoActivo> TipoActivoCtaDeterioroCNavigations { get; set; }
        public virtual ICollection<TipoActivo> TipoActivoCtaDeterioroFNavigations { get; set; }
        public virtual ICollection<TipoActivo> TipoActivoCtaGastoDeterioroCNavigations { get; set; }
        public virtual ICollection<TipoActivo> TipoActivoCtaGastoDeterioroFNavigations { get; set; }
    }
}
