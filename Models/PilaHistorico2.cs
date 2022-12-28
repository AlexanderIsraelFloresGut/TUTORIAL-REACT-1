using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class PilaHistorico2
    {
        public string Nomina { get; set; } = null!;
        public short NumeroNomina { get; set; }
        public string TipoRegistro { get; set; } = null!;
        public string? EcnModalidad { get; set; }
        public string Secuencia { get; set; } = null!;
        public string? EcnRazonSocial { get; set; }
        public string? EcnTipoDocAportante { get; set; }
        public string? EcnIdAportante { get; set; }
        public string? EcnDigitoVerificador { get; set; }
        public string? EcnTipoPlanilla { get; set; }
        public string? EcnNumeroPlanilla { get; set; }
        public string? EcnFechaPagoPlanilla { get; set; }
        public string? EcnFormaPresenta { get; set; }
        public string? EcnCodigoSucursal { get; set; }
        public string? EcnNombreSucursal { get; set; }
        public string? EcnCodigoArl { get; set; }
        public string? EcnPeriodoDifSalud { get; set; }
        public string? EcnPeriodoSalud { get; set; }
        public string? EcnNumeroRadicacion { get; set; }
        public string? EcnFechaPago { get; set; }
        public int? EcnTotalEmpleados { get; set; }
        public decimal? EcnValorTotalNom { get; set; }
        public string? EcnTipoAportante { get; set; }
        public string? EcnCodigoOperador { get; set; }
        public string? ApCodigoAdmin { get; set; }
        public string? ApNitAdmin { get; set; }
        public string? ApDigitoVerificador { get; set; }
        public decimal? ApCotObligatorias { get; set; }
        public decimal? ApCotVolAfiliados { get; set; }
        public decimal? ApCotVolAportante { get; set; }
        public decimal? ApAporteFonSubSol { get; set; }
        public decimal? ApAporteFonSubSub { get; set; }
        public decimal? ApDiasMoraLiq { get; set; }
        public decimal? ApIntMoraLiq { get; set; }
        public decimal? ApIntMoraSol { get; set; }
        public decimal? ApIntMoraSub { get; set; }
        public decimal? TotalPagarAdmin { get; set; }
        public decimal? TotalPagarAfiliados { get; set; }
        public string? ArpCodigoArl { get; set; }
        public string? ArpNitArl { get; set; }
        public string? ArpDigitoVerificador { get; set; }
        public decimal? ArpTotalCotizaciones { get; set; }
        public decimal? ArpNumAutorizacion { get; set; }
        public decimal? ArpTotalIncapPag { get; set; }
        public decimal? ArpAporOtrosSist { get; set; }
        public decimal? ArpNetosAportes { get; set; }
        public decimal? ArpDiasMoraLiq { get; set; }
        public decimal? ArpIntMora { get; set; }
        public decimal? ArpSubtotalAportes { get; set; }
        public string? ArpFormulario { get; set; }
        public decimal? ArpSaldoFavor { get; set; }
        public decimal? ArpTotalPagarAdm { get; set; }
        public decimal? ArpRiesgosLaborales { get; set; }
        public decimal? ArpTotalAfiliados { get; set; }
        public string? EpsCodigo { get; set; }
        public string? EpsNit { get; set; }
        public string? EpsDigitoVerificador { get; set; }
        public decimal? EpsCotizacionesOblig { get; set; }
        public decimal? EpsUpcAdicional { get; set; }
        public decimal? EpsNumAutorInc { get; set; }
        public decimal? EpsIncapacPag { get; set; }
        public decimal? EpsNumAutorizacionMat { get; set; }
        public decimal? EpsLicMaternidadPag { get; set; }
        public decimal? EpsNetoAportesCot { get; set; }
        public decimal? EpsDiasMoraLiq { get; set; }
        public decimal? EpsIntMora { get; set; }
        public decimal? EpsIntMoraUpc { get; set; }
        public decimal? EpsSubAportes { get; set; }
        public decimal? EpsSubUpc { get; set; }
        public string? EpsNumFormulario { get; set; }
        public decimal? EpsSaldoFavorAnterior { get; set; }
        public decimal? EpsSaldosFavorUpc { get; set; }
        public decimal? EpsTotalPagar { get; set; }
        public decimal? EpsTotalPagarUpc { get; set; }
        public decimal? EpsTotalPagarAdmin { get; set; }
        public decimal? EpsFondoSolidGaran { get; set; }
        public int? EpsTotalAfiliados { get; set; }
        public string? CcfCodigo { get; set; }
        public string? CcfNit { get; set; }
        public string? CcfDigitoVerificador { get; set; }
        public decimal? CcfValorAportes { get; set; }
        public decimal? CcfDiasMoraLiq { get; set; }
        public decimal? CcfIntMora { get; set; }
        public decimal? CcfTotalPagar { get; set; }
        public int? CcfTotalAfiliados { get; set; }
        public string? SenaNit { get; set; }
        public string? SenaDigitoVerificador { get; set; }
        public decimal? SenaValorAporte { get; set; }
        public decimal? SenaDiasMoraLiq { get; set; }
        public decimal? SenaIntMora { get; set; }
        public decimal? SenaTotalPagar { get; set; }
        public int? SenaTotalAfiliados { get; set; }
        public string? IcbfNit { get; set; }
        public string? IcbfDigitoVerificador { get; set; }
        public decimal? IcbfValorAporte { get; set; }
        public decimal? IcbfDiasMoraLiq { get; set; }
        public decimal? IcbfIntMora { get; set; }
        public decimal? IcbfTotalPagar { get; set; }
        public int? IcbfTotalAfiliados { get; set; }
        public string? EsapNit { get; set; }
        public string? EsapDigitoVerificador { get; set; }
        public decimal? EsapValorPagar { get; set; }
        public decimal? EsapDiasMoraLiq { get; set; }
        public decimal? EsapIntMora { get; set; }
        public decimal? EsapTotalPagar { get; set; }
        public string? MenNit { get; set; }
        public string? MenDigitoVerificador { get; set; }
        public decimal? MenValorPagar { get; set; }
        public decimal? MenDiasMoraLiq { get; set; }
        public decimal? MenIntMora { get; set; }
        public decimal? MenTotalPagar { get; set; }
        public decimal? TotalPensiones { get; set; }
        public decimal? TotalFonSolPen { get; set; }
        public decimal? TotalSalud { get; set; }
        public decimal? TotalRiesgosLab { get; set; }
        public decimal? TotalCcf { get; set; }
        public decimal? TotalSena { get; set; }
        public decimal? TotalIcbf { get; set; }
        public decimal? TotalEsap { get; set; }
        public decimal? TotalMen { get; set; }
        public decimal? TotalGranTotal { get; set; }
        public int? TotalNumAdminPen { get; set; }
        public int? TotalNumAdminEps { get; set; }
        public int? TotalNumAdminArl { get; set; }
        public int? TotalNumAdminCcf { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual NominaHistorico2 N { get; set; } = null!;
    }
}
