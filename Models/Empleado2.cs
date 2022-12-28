using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class Empleado2
    {
        public Empleado2()
        {
            Adicionalempleado2s = new HashSet<Adicionalempleado2>();
            BodegaEncargado2s = new HashSet<BodegaEncargado2>();
            CalcVacDetalle2s = new HashSet<CalcVacDetalle2>();
            CalculoVacacional2s = new HashSet<CalculoVacacional2>();
            ControlHorasIncap2s = new HashSet<ControlHorasIncap2>();
            CreditoEmpleado2s = new HashSet<CreditoEmpleado2>();
            EmpConcLiquidac2s = new HashSet<EmpConcLiquidac2>();
            EmpExperiencium2s = new HashSet<EmpExperiencium2>();
            EmpleadoAcademico2s = new HashSet<EmpleadoAcademico2>();
            EmpleadoAccPer2s = new HashSet<EmpleadoAccPer2>();
            EmpleadoAccidente2s = new HashSet<EmpleadoAccidente2>();
            EmpleadoAusencium2s = new HashSet<EmpleadoAusencium2>();
            EmpleadoCalendar2s = new HashSet<EmpleadoCalendar2>();
            EmpleadoCentro2s = new HashSet<EmpleadoCentro2>();
            EmpleadoComprobante2s = new HashSet<EmpleadoComprobante2>();
            EmpleadoConcNomi2s = new HashSet<EmpleadoConcNomi2>();
            EmpleadoConcepto2s = new HashSet<EmpleadoConcepto2>();
            EmpleadoContrato2s = new HashSet<EmpleadoContrato2>();
            EmpleadoDocumento2s = new HashSet<EmpleadoDocumento2>();
            EmpleadoEvaluacio2s = new HashSet<EmpleadoEvaluacio2>();
            EmpleadoJerarquium2SubordinadoNavigations = new HashSet<EmpleadoJerarquium2>();
            EmpleadoJerarquium2SuperiorNavigations = new HashSet<EmpleadoJerarquium2>();
            EmpleadoNomiNeto2s = new HashSet<EmpleadoNomiNeto2>();
            EmpleadoPariente2s = new HashSet<EmpleadoPariente2>();
            EmpleadoSaldoVac2s = new HashSet<EmpleadoSaldoVac2>();
            FiltroEmpleadoReporte2s = new HashSet<FiltroEmpleadoReporte2>();
            GrupoTrabajoPcLinea2s = new HashSet<GrupoTrabajoPcLinea2>();
            HistoricoEmpleado2EmpleadoNavigations = new HashSet<HistoricoEmpleado2>();
            HistoricoEmpleado2JefeNavigations = new HashSet<HistoricoEmpleado2>();
            HoraLaboradum2s = new HashSet<HoraLaboradum2>();
            Liquidacion2s = new HashSet<Liquidacion2>();
            MarcaReloj2s = new HashSet<MarcaReloj2>();
            OpOperDetMo2s = new HashSet<OpOperDetMo2>();
            PilaHistoricoDet2s = new HashSet<PilaHistoricoDet2>();
            Responsable2s = new HashSet<Responsable2>();
            SalDiarioIntDet2s = new HashSet<SalDiarioIntDet2>();
            SalDiarioIntEmp2s = new HashSet<SalDiarioIntEmp2>();
            SolicitudRh2EmpleadoNavigations = new HashSet<SolicitudRh2>();
            SolicitudRh2GeneradaPorNavigations = new HashSet<SolicitudRh2>();
            SolicitudRhNotif2s = new HashSet<SolicitudRhNotif2>();
            TipoSoliRhNotif2s = new HashSet<TipoSoliRhNotif2>();
        }

        public string Empleado { get; set; } = null!;
        public int? DetalleDirHab { get; set; }
        public string Nombre { get; set; } = null!;
        public string Sexo { get; set; } = null!;
        public string? TipoSangre { get; set; }
        public string EstadoEmpleado { get; set; } = null!;
        public string Activo { get; set; } = null!;
        public string? Identificacion { get; set; }
        public string? Pasaporte { get; set; }
        public DateTime FechaIngreso { get; set; }
        public DateTime? FechaSalida { get; set; }
        public string Departamento { get; set; } = null!;
        public string Puesto { get; set; } = null!;
        public string Plaza { get; set; } = null!;
        public string Nomina { get; set; } = null!;
        public string CentroCosto { get; set; } = null!;
        public DateTime FechaNacimiento { get; set; }
        public string Ubicacion { get; set; } = null!;
        public string Pais { get; set; } = null!;
        public string EstadoCivil { get; set; } = null!;
        public short? Dependientes { get; set; }
        public string? Asegurado { get; set; }
        public string? ClaseSeguro { get; set; }
        public string? PermisoConducir { get; set; }
        public string? PermisoSalud { get; set; }
        public string? Nit { get; set; }
        public decimal VacsPendientes { get; set; }
        public DateTime VacsUltCalculo { get; set; }
        public DateTime? FechaProxEval { get; set; }
        public decimal SalarioReferencia { get; set; }
        public string FormaPago { get; set; } = null!;
        public string? CuentaEntidad { get; set; }
        public string? EntidadFinanciera { get; set; }
        public string Horario { get; set; } = null!;
        public string? DireccionHab { get; set; }
        public string? DireccionPostal { get; set; }
        public string? Telefono1 { get; set; }
        public string? NotasTel1 { get; set; }
        public string? Telefono2 { get; set; }
        public string? NotasTel2 { get; set; }
        public string? Telefono3 { get; set; }
        public string? NotasTel3 { get; set; }
        public byte[]? Fotografia { get; set; }
        public string? Rubro1 { get; set; }
        public string? Rubro2 { get; set; }
        public string? Rubro3 { get; set; }
        public string? Rubro4 { get; set; }
        public string? Rubro5 { get; set; }
        public string? Rubro6 { get; set; }
        public string? Rubro7 { get; set; }
        public string? Rubro8 { get; set; }
        public string? Rubro9 { get; set; }
        public string? Rubro10 { get; set; }
        public string? Rubro11 { get; set; }
        public string? Rubro12 { get; set; }
        public string? Rubro13 { get; set; }
        public string? Rubro14 { get; set; }
        public string? Rubro15 { get; set; }
        public DateTime FechaNoPago { get; set; }
        public string TipoSalarioAumen { get; set; } = null!;
        public DateTime? FechaAntigEmp { get; set; }
        public DateTime? FechaAntigGob { get; set; }
        public decimal? SalarioDiarioInt { get; set; }
        public string? PrimerApellido { get; set; }
        public string? SegundoApellido { get; set; }
        public string? NombrePila { get; set; }
        public string? EMail { get; set; }
        public int? DetalleDirPostal { get; set; }
        public decimal VacsAdicionales { get; set; }
        public string? Rubro16 { get; set; }
        public string? Rubro17 { get; set; }
        public string? Rubro18 { get; set; }
        public string? Rubro19 { get; set; }
        public string? Rubro20 { get; set; }
        public string? Rubro21 { get; set; }
        public string? Rubro22 { get; set; }
        public string? Rubro23 { get; set; }
        public string? Rubro24 { get; set; }
        public string? Rubro25 { get; set; }
        public decimal? SalariopdLocal { get; set; }
        public decimal? SalariopdDolar { get; set; }
        public decimal? SalariopdNomina { get; set; }
        public decimal? DiasDispIncap { get; set; }
        public string? UsuarioCreacion { get; set; }
        public DateTime? FechaHoraCreacion { get; set; }
        public string? UsuarioUltMod { get; set; }
        public DateTime? FchHoraUltMod { get; set; }
        public string? TipoCuentaEntidad { get; set; }
        public string? CtaElectronica { get; set; }
        public string? DivisionGeografica1 { get; set; }
        public string? DivisionGeografica2 { get; set; }
        public string? PaisDirec { get; set; }
        public string? TipoSalario { get; set; }
        public string? BeneficioColectivo { get; set; }
        public int? TipoMedidasCertificadas { get; set; }
        public int? TipoNivelEducativo { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
        public string? UTdep { get; set; }
        public string? UCodSucursal { get; set; }
        public string? UTipoPlanilla { get; set; }
        public string? TipoTrabajadorNe { get; set; }
        public string? SubtipoTrabajadorNe { get; set; }
        public string? FormaPagoNe { get; set; }
        public string? MedioPagoNe { get; set; }

        public virtual CentroCosto2 CentroCostoNavigation { get; set; } = null!;
        public virtual ClaseSeguro2? ClaseSeguroNavigation { get; set; }
        public virtual Departamento2 DepartamentoNavigation { get; set; } = null!;
        public virtual DetalleDireccion2? DetalleDirHabNavigation { get; set; }
        public virtual DetalleDireccion2? DetalleDirPostalNavigation { get; set; }
        public virtual EntidadFinanciera2? EntidadFinancieraNavigation { get; set; }
        public virtual EstadoEmpleado2 EstadoEmpleadoNavigation { get; set; } = null!;
        public virtual FormaPagoNe2? FormaPagoNeNavigation { get; set; }
        public virtual Horario2 HorarioNavigation { get; set; } = null!;
        public virtual MedioPagoNe2? MedioPagoNeNavigation { get; set; }
        public virtual Nit2? NitNavigation { get; set; }
        public virtual Nomina2 NominaNavigation { get; set; } = null!;
        public virtual Plaza2 P { get; set; } = null!;
        public virtual Pai2? PaisDirecNavigation { get; set; }
        public virtual Pai2 PaisNavigation { get; set; } = null!;
        public virtual SubtipoTrabajadorNe2? SubtipoTrabajadorNeNavigation { get; set; }
        public virtual TipoCuentum2? TipoCuentaEntidadNavigation { get; set; }
        public virtual TipoTrabajadorNe2? TipoTrabajadorNeNavigation { get; set; }
        public virtual Ubicacion2 UbicacionNavigation { get; set; } = null!;
        public virtual Usuario2? UsuarioCreacionNavigation { get; set; }
        public virtual Usuario2? UsuarioUltModNavigation { get; set; }
        public virtual Cotizante2 Cotizante2 { get; set; } = null!;
        public virtual EmpleadoNota2 EmpleadoNota2 { get; set; } = null!;
        public virtual EmpleadoVacacion2 EmpleadoVacacion2 { get; set; } = null!;
        public virtual ICollection<Adicionalempleado2> Adicionalempleado2s { get; set; }
        public virtual ICollection<BodegaEncargado2> BodegaEncargado2s { get; set; }
        public virtual ICollection<CalcVacDetalle2> CalcVacDetalle2s { get; set; }
        public virtual ICollection<CalculoVacacional2> CalculoVacacional2s { get; set; }
        public virtual ICollection<ControlHorasIncap2> ControlHorasIncap2s { get; set; }
        public virtual ICollection<CreditoEmpleado2> CreditoEmpleado2s { get; set; }
        public virtual ICollection<EmpConcLiquidac2> EmpConcLiquidac2s { get; set; }
        public virtual ICollection<EmpExperiencium2> EmpExperiencium2s { get; set; }
        public virtual ICollection<EmpleadoAcademico2> EmpleadoAcademico2s { get; set; }
        public virtual ICollection<EmpleadoAccPer2> EmpleadoAccPer2s { get; set; }
        public virtual ICollection<EmpleadoAccidente2> EmpleadoAccidente2s { get; set; }
        public virtual ICollection<EmpleadoAusencium2> EmpleadoAusencium2s { get; set; }
        public virtual ICollection<EmpleadoCalendar2> EmpleadoCalendar2s { get; set; }
        public virtual ICollection<EmpleadoCentro2> EmpleadoCentro2s { get; set; }
        public virtual ICollection<EmpleadoComprobante2> EmpleadoComprobante2s { get; set; }
        public virtual ICollection<EmpleadoConcNomi2> EmpleadoConcNomi2s { get; set; }
        public virtual ICollection<EmpleadoConcepto2> EmpleadoConcepto2s { get; set; }
        public virtual ICollection<EmpleadoContrato2> EmpleadoContrato2s { get; set; }
        public virtual ICollection<EmpleadoDocumento2> EmpleadoDocumento2s { get; set; }
        public virtual ICollection<EmpleadoEvaluacio2> EmpleadoEvaluacio2s { get; set; }
        public virtual ICollection<EmpleadoJerarquium2> EmpleadoJerarquium2SubordinadoNavigations { get; set; }
        public virtual ICollection<EmpleadoJerarquium2> EmpleadoJerarquium2SuperiorNavigations { get; set; }
        public virtual ICollection<EmpleadoNomiNeto2> EmpleadoNomiNeto2s { get; set; }
        public virtual ICollection<EmpleadoPariente2> EmpleadoPariente2s { get; set; }
        public virtual ICollection<EmpleadoSaldoVac2> EmpleadoSaldoVac2s { get; set; }
        public virtual ICollection<FiltroEmpleadoReporte2> FiltroEmpleadoReporte2s { get; set; }
        public virtual ICollection<GrupoTrabajoPcLinea2> GrupoTrabajoPcLinea2s { get; set; }
        public virtual ICollection<HistoricoEmpleado2> HistoricoEmpleado2EmpleadoNavigations { get; set; }
        public virtual ICollection<HistoricoEmpleado2> HistoricoEmpleado2JefeNavigations { get; set; }
        public virtual ICollection<HoraLaboradum2> HoraLaboradum2s { get; set; }
        public virtual ICollection<Liquidacion2> Liquidacion2s { get; set; }
        public virtual ICollection<MarcaReloj2> MarcaReloj2s { get; set; }
        public virtual ICollection<OpOperDetMo2> OpOperDetMo2s { get; set; }
        public virtual ICollection<PilaHistoricoDet2> PilaHistoricoDet2s { get; set; }
        public virtual ICollection<Responsable2> Responsable2s { get; set; }
        public virtual ICollection<SalDiarioIntDet2> SalDiarioIntDet2s { get; set; }
        public virtual ICollection<SalDiarioIntEmp2> SalDiarioIntEmp2s { get; set; }
        public virtual ICollection<SolicitudRh2> SolicitudRh2EmpleadoNavigations { get; set; }
        public virtual ICollection<SolicitudRh2> SolicitudRh2GeneradaPorNavigations { get; set; }
        public virtual ICollection<SolicitudRhNotif2> SolicitudRhNotif2s { get; set; }
        public virtual ICollection<TipoSoliRhNotif2> TipoSoliRhNotif2s { get; set; }
    }
}
