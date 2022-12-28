using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class CuentaContable2
    {
        public CuentaContable2()
        {
            CentroConcepto2CuentaContableNavigations = new HashSet<CentroConcepto2>();
            CentroConcepto2CuentaContraNavigations = new HashSet<CentroConcepto2>();
            CentroCuentum2s = new HashSet<CentroCuentum2>();
            CtaAjusteInfl2ContraCtaAjusteNavigations = new HashSet<CtaAjusteInfl2>();
            CtaAjusteInfl2CtaAjusteNavigations = new HashSet<CtaAjusteInfl2>();
            CuentaDepreciacio2CtaDeprAiCNavigations = new HashSet<CuentaDepreciacio2>();
            CuentaDepreciacio2CtaDeprAiFNavigations = new HashSet<CuentaDepreciacio2>();
            CuentaDepreciacio2CtaDeprDesmantelaCNavigations = new HashSet<CuentaDepreciacio2>();
            CuentaDepreciacio2CtaDeprDesmantelaFNavigations = new HashSet<CuentaDepreciacio2>();
            CuentaDepreciacio2CtaDeprNormalCNavigations = new HashSet<CuentaDepreciacio2>();
            CuentaDepreciacio2CtaDeprNormalNavigations = new HashSet<CuentaDepreciacio2>();
            CuentaDepreciacio2CtaDeprRevalCNavigations = new HashSet<CuentaDepreciacio2>();
            CuentaDepreciacio2CtaDeprRevalNavigations = new HashSet<CuentaDepreciacio2>();
            CuentaSeccion2s = new HashSet<CuentaSeccion2>();
            FacturaLinea2s = new HashSet<FacturaLinea2>();
            PedidoLinea2s = new HashSet<PedidoLinea2>();
            TipoActivo2CtaAiDeprecCNavigations = new HashSet<TipoActivo2>();
            TipoActivo2CtaAiDeprecNavigations = new HashSet<TipoActivo2>();
            TipoActivo2CtaAjuInflacCNavigations = new HashSet<TipoActivo2>();
            TipoActivo2CtaAjuInflacNavigations = new HashSet<TipoActivo2>();
            TipoActivo2CtaDeprDesmanCNavigations = new HashSet<TipoActivo2>();
            TipoActivo2CtaDeprDesmanFNavigations = new HashSet<TipoActivo2>();
            TipoActivo2CtaDesmanCNavigations = new HashSet<TipoActivo2>();
            TipoActivo2CtaDesmanFNavigations = new HashSet<TipoActivo2>();
            TipoActivo2CtaDeterioroCNavigations = new HashSet<TipoActivo2>();
            TipoActivo2CtaDeterioroFNavigations = new HashSet<TipoActivo2>();
            TipoActivo2CtaGastoDeterioroCNavigations = new HashSet<TipoActivo2>();
            TipoActivo2CtaGastoDeterioroFNavigations = new HashSet<TipoActivo2>();
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
        public string ManejaTercero { get; set; } = null!;

        public virtual SeccionCuentum2? SeccionCuentaNavigation { get; set; }
        public virtual TipoCambio2 TipoCambioNavigation { get; set; } = null!;
        public virtual Unidad2? UnidadNavigation { get; set; }
        public virtual Usuario2 UsuarioNavigation { get; set; } = null!;
        public virtual Usuario2 UsuarioUltModNavigation { get; set; } = null!;
        public virtual CtaAjusteInfl2 CtaAjusteInfl2CtaAjustableNavigation { get; set; } = null!;
        public virtual ICollection<CentroConcepto2> CentroConcepto2CuentaContableNavigations { get; set; }
        public virtual ICollection<CentroConcepto2> CentroConcepto2CuentaContraNavigations { get; set; }
        public virtual ICollection<CentroCuentum2> CentroCuentum2s { get; set; }
        public virtual ICollection<CtaAjusteInfl2> CtaAjusteInfl2ContraCtaAjusteNavigations { get; set; }
        public virtual ICollection<CtaAjusteInfl2> CtaAjusteInfl2CtaAjusteNavigations { get; set; }
        public virtual ICollection<CuentaDepreciacio2> CuentaDepreciacio2CtaDeprAiCNavigations { get; set; }
        public virtual ICollection<CuentaDepreciacio2> CuentaDepreciacio2CtaDeprAiFNavigations { get; set; }
        public virtual ICollection<CuentaDepreciacio2> CuentaDepreciacio2CtaDeprDesmantelaCNavigations { get; set; }
        public virtual ICollection<CuentaDepreciacio2> CuentaDepreciacio2CtaDeprDesmantelaFNavigations { get; set; }
        public virtual ICollection<CuentaDepreciacio2> CuentaDepreciacio2CtaDeprNormalCNavigations { get; set; }
        public virtual ICollection<CuentaDepreciacio2> CuentaDepreciacio2CtaDeprNormalNavigations { get; set; }
        public virtual ICollection<CuentaDepreciacio2> CuentaDepreciacio2CtaDeprRevalCNavigations { get; set; }
        public virtual ICollection<CuentaDepreciacio2> CuentaDepreciacio2CtaDeprRevalNavigations { get; set; }
        public virtual ICollection<CuentaSeccion2> CuentaSeccion2s { get; set; }
        public virtual ICollection<FacturaLinea2> FacturaLinea2s { get; set; }
        public virtual ICollection<PedidoLinea2> PedidoLinea2s { get; set; }
        public virtual ICollection<TipoActivo2> TipoActivo2CtaAiDeprecCNavigations { get; set; }
        public virtual ICollection<TipoActivo2> TipoActivo2CtaAiDeprecNavigations { get; set; }
        public virtual ICollection<TipoActivo2> TipoActivo2CtaAjuInflacCNavigations { get; set; }
        public virtual ICollection<TipoActivo2> TipoActivo2CtaAjuInflacNavigations { get; set; }
        public virtual ICollection<TipoActivo2> TipoActivo2CtaDeprDesmanCNavigations { get; set; }
        public virtual ICollection<TipoActivo2> TipoActivo2CtaDeprDesmanFNavigations { get; set; }
        public virtual ICollection<TipoActivo2> TipoActivo2CtaDesmanCNavigations { get; set; }
        public virtual ICollection<TipoActivo2> TipoActivo2CtaDesmanFNavigations { get; set; }
        public virtual ICollection<TipoActivo2> TipoActivo2CtaDeterioroCNavigations { get; set; }
        public virtual ICollection<TipoActivo2> TipoActivo2CtaDeterioroFNavigations { get; set; }
        public virtual ICollection<TipoActivo2> TipoActivo2CtaGastoDeterioroCNavigations { get; set; }
        public virtual ICollection<TipoActivo2> TipoActivo2CtaGastoDeterioroFNavigations { get; set; }
    }
}
