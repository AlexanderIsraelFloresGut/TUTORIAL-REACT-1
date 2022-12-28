using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class PilaHistoricoDet1
    {
        public string Nomina { get; set; } = null!;
        public short NumeroNomina { get; set; }
        public string Empleado { get; set; } = null!;
        public string TipoRegistro { get; set; } = null!;
        public int Secuencia { get; set; }
        public string? TipoDoc { get; set; }
        public string? IdCotizante { get; set; }
        public string? TipoCotizante { get; set; }
        public string? SubtipoCotizante { get; set; }
        public string? Extranjero { get; set; }
        public string? ColombianoExterior { get; set; }
        public string? CodigoDepto { get; set; }
        public string? CodigoMunicipio { get; set; }
        public string? Ing { get; set; }
        public string? Ret { get; set; }
        public string? Eps { get; set; }
        public string? Tae { get; set; }
        public string? Tdp { get; set; }
        public string? Tap { get; set; }
        public string? Vsp { get; set; }
        public string? Correcciones { get; set; }
        public string? Vst { get; set; }
        public string? Sln { get; set; }
        public string? Ige { get; set; }
        public string? Lma { get; set; }
        public string? Vac { get; set; }
        public string? Avp { get; set; }
        public string? Vct { get; set; }
        public int? Irp { get; set; }
        public string? AdmPensiones { get; set; }
        public string? AdmTraslado { get; set; }
        public string? EpsPertenece { get; set; }
        public string? EpsTraslada { get; set; }
        public string? CcfPertenece { get; set; }
        public int? DiasPension { get; set; }
        public int? DiasSalud { get; set; }
        public int? DiasRiesgos { get; set; }
        public int? DiasCompensa { get; set; }
        public decimal? SalarioBasico { get; set; }
        public string? SalarioIntegral { get; set; }
        public decimal? IbcPension { get; set; }
        public decimal? IbcSalud { get; set; }
        public decimal? IbcRiesgos { get; set; }
        public decimal? IbcCcf { get; set; }
        public decimal? TarifaPensiones { get; set; }
        public decimal? CotObligPensiones { get; set; }
        public decimal? AporteVolAfilPen { get; set; }
        public decimal? AporteVolAporPen { get; set; }
        public decimal? CotSistPensiones { get; set; }
        public decimal? AporFonSoli { get; set; }
        public decimal? AporFonSubs { get; set; }
        public decimal? NoRetAporVol { get; set; }
        public decimal? TarAporSalud { get; set; }
        public decimal? CotObliSalud { get; set; }
        public decimal? UpcAdicional { get; set; }
        public string? AutorIeg { get; set; }
        public decimal? ValorIeg { get; set; }
        public string? AutorLma { get; set; }
        public decimal? ValorLma { get; set; }
        public decimal? TarAporRiesgos { get; set; }
        public decimal? CentroTrabajo { get; set; }
        public decimal? CotObliSistRiesgos { get; set; }
        public decimal? TarAportCcf { get; set; }
        public decimal? ValorAporteCcf { get; set; }
        public decimal? TarAporSena { get; set; }
        public decimal? ValorAporSena { get; set; }
        public decimal? TarAporIcbf { get; set; }
        public decimal? ValorAporIcbf { get; set; }
        public decimal? TarAporEsap { get; set; }
        public decimal? ValorAporEsap { get; set; }
        public decimal? TarAporMen { get; set; }
        public decimal? ValorAporMen { get; set; }
        public string? TipoDocCotPrin { get; set; }
        public string? NitCotPrin { get; set; }
        public string? CotExonerado { get; set; }
        public string? AdmRiesgosProf { get; set; }
        public string? ClaseRiesgo { get; set; }
        public string? TarEspPen { get; set; }
        public DateTime? FechaIngreso { get; set; }
        public DateTime? FechaRetiro { get; set; }
        public DateTime? InicioVsp { get; set; }
        public DateTime? InicioSln { get; set; }
        public DateTime? FinSln { get; set; }
        public DateTime? InicioIge { get; set; }
        public DateTime? FinalIge { get; set; }
        public DateTime? InicioLma { get; set; }
        public DateTime? FinalLma { get; set; }
        public DateTime? InicioVac { get; set; }
        public DateTime? FinalVac { get; set; }
        public DateTime? InicioVct { get; set; }
        public DateTime? FinVct { get; set; }
        public DateTime? InicioIrl { get; set; }
        public DateTime? FinalIrl { get; set; }
        public decimal? IbcOtrosPara { get; set; }
        public decimal? HorasLaboradas { get; set; }
        public DateTime? FechaExterior { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual Empleado1 EmpleadoNavigation { get; set; } = null!;
        public virtual NominaHistorico1 N { get; set; } = null!;
    }
}
