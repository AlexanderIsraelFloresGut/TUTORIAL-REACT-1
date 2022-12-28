using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class GlobalesAf2
    {
        public string? CtaCorreccDa { get; set; }
        public DateTime? FechaUltComp { get; set; }
        public string? CtaOrdenVenta { get; set; }
        public string? CtrSuperavit { get; set; }
        public string? CtaSuperavit { get; set; }
        public string? CtrRei { get; set; }
        public string? CtaRei { get; set; }
        public string? Paquete { get; set; }
        public string? TipoAsiento { get; set; }
        public string? AsntInclusion { get; set; }
        public string AjustarCalcDepr { get; set; } = null!;
        public string? CtrUtilidadVenta { get; set; }
        public string? CtaUtilidadVenta { get; set; }
        public string? CtrPerdidaVenta { get; set; }
        public string? CtaPerdidaVenta { get; set; }
        public string? CtrOrdenIngreso { get; set; }
        public string? CtaOrdenIngreso { get; set; }
        public string? CtrOrdenVenta { get; set; }
        public string? AsntExclusion { get; set; }
        public string? MejDeprActivo { get; set; }
        public string? MejRevalActivo { get; set; }
        public string? MejVidaActivo { get; set; }
        public string? TipoFasb52 { get; set; }
        public short? MesesReval { get; set; }
        public string? TipoConsecutivo { get; set; }
        public string? Consecutivo { get; set; }
        public string IntegracionConta { get; set; } = null!;
        public short ModAplicAsiento { get; set; }
        public string TipoContaOmision { get; set; } = null!;
        public string? CorporativaActiva { get; set; }
        public string? PermitirRevalNeg { get; set; }
        public string? ContabilidadReval { get; set; }
        public int UltDepreciacion { get; set; }
        public int UltRevaluacion { get; set; }
        public string? AccionesIng { get; set; }
        public string? AccionesRet { get; set; }
        public string? CtrCorreccDa { get; set; }
        public string AjusteInflac { get; set; } = null!;
        public string? AccionesCentro { get; set; }
        public string? NomRubro1Act { get; set; }
        public string? NomRubro2Act { get; set; }
        public string? NomRubro3Act { get; set; }
        public string? NomRubro4Act { get; set; }
        public string? NomRubro5Act { get; set; }
        public string? NomRubro6Act { get; set; }
        public string? NomRubro7Act { get; set; }
        public string? NomRubro8Act { get; set; }
        public string? NomRubro9Act { get; set; }
        public string? NomRubro10Act { get; set; }
        public string? NomRubro11Act { get; set; }
        public string? NomRubro12Act { get; set; }
        public string? NomRubro13Act { get; set; }
        public string? NomRubro14Act { get; set; }
        public string? NomRubro15Act { get; set; }
        public short CantDecimales { get; set; }
        public string TruncarValor { get; set; } = null!;
        public string CondActivos { get; set; } = null!;
        public string OpcionDepr { get; set; } = null!;
        public string UsaComponentes { get; set; } = null!;
        public string? CtrAjuInflac { get; set; }
        public string? CtaAjuInflac { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
        public string DesmanDeprActivo { get; set; } = null!;
        public string? CtrDeterioro { get; set; }
        public string? CtaDeterioro { get; set; }
        public int UltDeterioro { get; set; }
        public string DesmanVidaActivo { get; set; } = null!;
        public string ContaImpuesto { get; set; } = null!;

        public virtual TipoAccionAf2? AccionesCentroNavigation { get; set; }
        public virtual CentroCuentum2? Ct { get; set; }
        public virtual CentroCuentum2? Ct1 { get; set; }
        public virtual CentroCuentum2? Ct2 { get; set; }
        public virtual CentroCuentum2? Ct3 { get; set; }
        public virtual CentroCuentum2? Ct4 { get; set; }
        public virtual CentroCuentum2? Ct5 { get; set; }
        public virtual CentroCuentum2? CtNavigation { get; set; }
        public virtual CuentaContable2? CtaAjuInflacNavigation { get; set; }
        public virtual CuentaContable2? CtaDeterioroNavigation { get; set; }
        public virtual CentroCosto2? CtrAjuInflacNavigation { get; set; }
        public virtual CentroCosto2? CtrDeterioroNavigation { get; set; }
        public virtual Paquete2? PaqueteNavigation { get; set; }
        public virtual TipoAsiento2? TipoAsientoNavigation { get; set; }
    }
}
