using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class TipoActivo2
    {
        public TipoActivo2()
        {
            ActivoFijo2s = new HashSet<ActivoFijo2>();
            CuentaDepreciacio2s = new HashSet<CuentaDepreciacio2>();
        }

        public string TipoActivo { get; set; } = null!;
        public string? CtaRevalDa { get; set; }
        public string Descripcion { get; set; } = null!;
        public string TipoDeprFiscal { get; set; } = null!;
        public string TipoDeprComp { get; set; } = null!;
        public string UsaDeprPorc { get; set; } = null!;
        public string? Suma100DeprPorc { get; set; }
        public string TipoReval { get; set; } = null!;
        public decimal PorcReval { get; set; }
        public string? CtrActivo { get; set; }
        public string? CtaActivo { get; set; }
        public string? CtrDeprAcumNorm { get; set; }
        public string? CtaDeprAcumNorm { get; set; }
        public string? CtrRevaluacion { get; set; }
        public string? CtaRevaluacion { get; set; }
        public string? CtrDeprAcumRev { get; set; }
        public string? CtaDeprAcumRev { get; set; }
        public string? TipoIndicePrecio { get; set; }
        public string? Consecutivo { get; set; }
        public string? CtrRevalDa { get; set; }
        public decimal? PorcCompExt { get; set; }
        public decimal? PorcCompLoc { get; set; }
        public string? IndRevComp1 { get; set; }
        public string? IndRevComp2 { get; set; }
        public string? IndRevComp3 { get; set; }
        public string TipoRevalC { get; set; } = null!;
        public decimal? PorcRevalC { get; set; }
        public string? TipoIndicePrecioC { get; set; }
        public decimal? PorcDeprFiscal { get; set; }
        public decimal? PorcDeprComp { get; set; }
        public decimal? TasaDepreciacionF { get; set; }
        public decimal? TasaDepreciacionC { get; set; }
        public string? CtrActivoC { get; set; }
        public string? CtaActivoC { get; set; }
        public string? CtrDeprAcumNormC { get; set; }
        public string? CtaDeprAcumNormC { get; set; }
        public string? CtrRevaluacionC { get; set; }
        public string? CtaRevaluacionC { get; set; }
        public string? CtrDeprAcumRevC { get; set; }
        public string? CtaDeprAcumRevC { get; set; }
        public string? CtrRevalDaC { get; set; }
        public string? CtaRevalDaC { get; set; }
        public string? CtrDeprAcumAiF { get; set; }
        public string? CtaDeprAcumAiF { get; set; }
        public string? CtrDeprAcumAiC { get; set; }
        public string? CtaDeprAcumAiC { get; set; }
        public string? CtrAjuInflac { get; set; }
        public string? CtaAjuInflac { get; set; }
        public string? CtrAjuInflacC { get; set; }
        public string? CtaAjuInflacC { get; set; }
        public string? CtrAiDeprec { get; set; }
        public string? CtaAiDeprec { get; set; }
        public string? CtrAiDeprecC { get; set; }
        public string? CtaAiDeprecC { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
        public string? CtrDeterioroC { get; set; }
        public string? CtaDeterioroC { get; set; }
        public string? CtrGastoDeterioroC { get; set; }
        public string? CtaGastoDeterioroC { get; set; }
        public string? CtrDesmanC { get; set; }
        public string? CtaDesmanC { get; set; }
        public string? CtrDeprDesmanC { get; set; }
        public string? CtaDeprDesmanC { get; set; }
        public string? CtrDeterioroF { get; set; }
        public string? CtaDeterioroF { get; set; }
        public string? CtrGastoDeterioroF { get; set; }
        public string? CtaGastoDeterioroF { get; set; }
        public string? CtrDesmanF { get; set; }
        public string? CtaDesmanF { get; set; }
        public string? CtrDeprDesmanF { get; set; }
        public string? CtaDeprDesmanF { get; set; }
        public string? EsTerreno { get; set; }
        public string? ConceptoMe { get; set; }

        public virtual CentroCuentum2? Ct { get; set; }
        public virtual CentroCuentum2? Ct1 { get; set; }
        public virtual CentroCuentum2? Ct10 { get; set; }
        public virtual CentroCuentum2? Ct2 { get; set; }
        public virtual CentroCuentum2? Ct3 { get; set; }
        public virtual CentroCuentum2? Ct4 { get; set; }
        public virtual CentroCuentum2? Ct5 { get; set; }
        public virtual CentroCuentum2? Ct6 { get; set; }
        public virtual CentroCuentum2? Ct7 { get; set; }
        public virtual CentroCuentum2? Ct8 { get; set; }
        public virtual CentroCuentum2? Ct9 { get; set; }
        public virtual CentroCuentum2? CtNavigation { get; set; }
        public virtual CuentaContable2? CtaAiDeprecCNavigation { get; set; }
        public virtual CuentaContable2? CtaAiDeprecNavigation { get; set; }
        public virtual CuentaContable2? CtaAjuInflacCNavigation { get; set; }
        public virtual CuentaContable2? CtaAjuInflacNavigation { get; set; }
        public virtual CuentaContable2? CtaDeprDesmanCNavigation { get; set; }
        public virtual CuentaContable2? CtaDeprDesmanFNavigation { get; set; }
        public virtual CuentaContable2? CtaDesmanCNavigation { get; set; }
        public virtual CuentaContable2? CtaDesmanFNavigation { get; set; }
        public virtual CuentaContable2? CtaDeterioroCNavigation { get; set; }
        public virtual CuentaContable2? CtaDeterioroFNavigation { get; set; }
        public virtual CuentaContable2? CtaGastoDeterioroCNavigation { get; set; }
        public virtual CuentaContable2? CtaGastoDeterioroFNavigation { get; set; }
        public virtual CentroCosto2? CtrAiDeprecCNavigation { get; set; }
        public virtual CentroCosto2? CtrAiDeprecNavigation { get; set; }
        public virtual CentroCosto2? CtrAjuInflacCNavigation { get; set; }
        public virtual CentroCosto2? CtrAjuInflacNavigation { get; set; }
        public virtual CentroCosto2? CtrDeprDesmanCNavigation { get; set; }
        public virtual CentroCosto2? CtrDeprDesmanFNavigation { get; set; }
        public virtual CentroCosto2? CtrDesmanCNavigation { get; set; }
        public virtual CentroCosto2? CtrDesmanFNavigation { get; set; }
        public virtual CentroCosto2? CtrDeterioroCNavigation { get; set; }
        public virtual CentroCosto2? CtrDeterioroFNavigation { get; set; }
        public virtual CentroCosto2? CtrGastoDeterioroCNavigation { get; set; }
        public virtual CentroCosto2? CtrGastoDeterioroFNavigation { get; set; }
        public virtual TipoIndicePrecio2? IndRevComp1Navigation { get; set; }
        public virtual TipoIndicePrecio2? IndRevComp2Navigation { get; set; }
        public virtual TipoIndicePrecio2? IndRevComp3Navigation { get; set; }
        public virtual TipoIndicePrecio2? TipoIndicePrecioCNavigation { get; set; }
        public virtual TipoIndicePrecio2? TipoIndicePrecioNavigation { get; set; }
        public virtual ICollection<ActivoFijo2> ActivoFijo2s { get; set; }
        public virtual ICollection<CuentaDepreciacio2> CuentaDepreciacio2s { get; set; }
    }
}
