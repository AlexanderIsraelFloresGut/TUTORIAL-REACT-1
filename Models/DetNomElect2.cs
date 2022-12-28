using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class DetNomElect2
    {
        public DateTime Periodo { get; set; }
        public string CodigoTrabajador { get; set; } = null!;
        public DateTime? FechaIngreso { get; set; }
        public DateTime? FechaRetiro { get; set; }
        public string? TipoTrabajadorNe { get; set; }
        public string? SubtipoTrabajadorNe { get; set; }
        public string? AltoRiesgoPension { get; set; }
        public string? TipoDocumento { get; set; }
        public string NumeroDocumento { get; set; } = null!;
        public string? PrimerApellido { get; set; }
        public string? SegundoApellido { get; set; }
        public string? PrimerNombre { get; set; }
        public string? OtrosNombres { get; set; }
        public string? Pais { get; set; }
        public string? Departamento { get; set; }
        public string? Municipio { get; set; }
        public string? Direccion { get; set; }
        public string SalarioIntegral { get; set; } = null!;
        public decimal Sueldo { get; set; }
        public string? FormaPagoNe { get; set; }
        public string? MetodoPagoNe { get; set; }
        public string? Banco { get; set; }
        public string? TipoCuenta { get; set; }
        public string? NumeroCuenta { get; set; }
        public decimal SueldoTrabajo { get; set; }
        public decimal AuxilioTransporte { get; set; }
        public decimal ViaticosManuSalarial { get; set; }
        public decimal ViaticosManuNoSalarial { get; set; }
        public decimal HedPago { get; set; }
        public decimal HedCantidad { get; set; }
        public decimal HedPorcentaje { get; set; }
        public decimal HenPago { get; set; }
        public decimal HenCantidad { get; set; }
        public decimal HenPorcentaje { get; set; }
        public decimal HrnPago { get; set; }
        public decimal HrnCantidad { get; set; }
        public decimal HrnPorcentaje { get; set; }
        public decimal HeddfPago { get; set; }
        public decimal HeddfCantidad { get; set; }
        public decimal HeddfPorcentaje { get; set; }
        public decimal HrddfPago { get; set; }
        public decimal HrddfCantidad { get; set; }
        public decimal HrddfPorcentaje { get; set; }
        public decimal HendfPago { get; set; }
        public decimal HendfCantidad { get; set; }
        public decimal HendfPorcentaje { get; set; }
        public decimal HrndfPago { get; set; }
        public decimal HrndfCantidad { get; set; }
        public decimal HrndfPorcentaje { get; set; }
        public decimal CesantiasInt { get; set; }
        public decimal CesantiasPorcentaje { get; set; }
        public decimal CesantiasCantidad { get; set; }
        public decimal IncapacidadPago { get; set; }
        public decimal BonificacionSalarial { get; set; }
        public decimal BonificacionNoSalarial { get; set; }
        public decimal AuxilioSalarial { get; set; }
        public decimal AuxilioNoSalarial { get; set; }
        public decimal CompensacionOrd { get; set; }
        public decimal CompensacionExt { get; set; }
        public decimal BonoPagoSalarial { get; set; }
        public decimal BonoNoPagoSalarial { get; set; }
        public decimal AlimenPagoSalarial { get; set; }
        public decimal AlimenNoPagoSalarial { get; set; }
        public decimal Comision { get; set; }
        public decimal PagoTercero { get; set; }
        public decimal PagoTerceroDev { get; set; }
        public decimal Anticipo { get; set; }
        public decimal Dotacion { get; set; }
        public decimal ApoyoSost { get; set; }
        public decimal Teletrabajo { get; set; }
        public decimal BonifRetiro { get; set; }
        public decimal Indemnizacion { get; set; }
        public decimal ReintegroDev { get; set; }
        public decimal FondoSpPorcentaje { get; set; }
        public decimal FondoSpDeduc { get; set; }
        public decimal FondoSpPorcentajeSub { get; set; }
        public decimal FondoSpDeducSub { get; set; }
        public decimal SindicatoDeducccion { get; set; }
        public decimal SindicatoPorcentaje { get; set; }
        public decimal SancionPublica { get; set; }
        public decimal SancionPrivada { get; set; }
        public decimal PensionVoluntaria { get; set; }
        public decimal RetencionFuente { get; set; }
        public decimal Ica { get; set; }
        public decimal Afc { get; set; }
        public decimal Cooperativa { get; set; }
        public decimal EmbargoFiscal { get; set; }
        public decimal PlanComplementario { get; set; }
        public decimal Educacion { get; set; }
        public decimal ReintegroDed { get; set; }
        public decimal Deuda { get; set; }
        public decimal CantVacComunes { get; set; }
        public decimal PagoVacComunes { get; set; }
        public decimal CantVacCompensadas { get; set; }
        public decimal PagoVacCompensadas { get; set; }
        public decimal PrimasPago { get; set; }
        public decimal PrimasNoSalarial { get; set; }
        public decimal PrimasCantidad { get; set; }
        public decimal CantLicenciaMp { get; set; }
        public decimal PagoLicenciaMp { get; set; }
        public decimal CantLicenciaR { get; set; }
        public decimal PagoLicenciaR { get; set; }
        public decimal CantLicenciaNr { get; set; }
        public decimal CantHuelga { get; set; }
        public decimal TiempoLaborado { get; set; }
        public decimal OtraDeduccion { get; set; }
        public decimal AnticipoDeduccion { get; set; }
        public int? PeriodoNomina { get; set; }
        public decimal SaludDeduccion { get; set; }
        public decimal SaludPorcentaje { get; set; }
        public decimal FondoPensionDeduccion { get; set; }
        public decimal FondoPensionPorcentaje { get; set; }
        public decimal DiasTrabajados { get; set; }
        public string? TipoContrato { get; set; }
        public string? FechasPago { get; set; }
        public decimal IncapacidadCantidad { get; set; }
        public decimal OtrosSalariales { get; set; }
        public decimal OtrosNoSalariales { get; set; }
        public decimal LibranzasDeduc { get; set; }
        public decimal TotalDevengados { get; set; }
        public decimal TotalDeducciones { get; set; }
        public decimal TotalComprobante { get; set; }
        public string? Pagos { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
    }
}
