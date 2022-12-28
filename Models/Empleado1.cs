using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class Empleado1
    {
        public Empleado1()
        {
            Adicionalempleado1s = new HashSet<Adicionalempleado1>();
            AsocHerram1s = new HashSet<AsocHerram1>();
            BodegaEncargado1s = new HashSet<BodegaEncargado1>();
            CalcVacDetalle1s = new HashSet<CalcVacDetalle1>();
            CalculoVacacional1s = new HashSet<CalculoVacacional1>();
            ControlHorasIncap1s = new HashSet<ControlHorasIncap1>();
            CreditoEmpleado1s = new HashSet<CreditoEmpleado1>();
            CsAreaOrgs = new HashSet<CsAreaOrg>();
            CsEmpleadoHorarios = new HashSet<CsEmpleadoHorario>();
            CsEstrucMo1s = new HashSet<CsEstrucMo1>();
            CsMarcada = new HashSet<CsMarcada>();
            EmpConcLiquidac1s = new HashSet<EmpConcLiquidac1>();
            EmpExperiencium1s = new HashSet<EmpExperiencium1>();
            EmpleadoAcademico1s = new HashSet<EmpleadoAcademico1>();
            EmpleadoAccPer1s = new HashSet<EmpleadoAccPer1>();
            EmpleadoAccidente1s = new HashSet<EmpleadoAccidente1>();
            EmpleadoAusencium1s = new HashSet<EmpleadoAusencium1>();
            EmpleadoCalendar1s = new HashSet<EmpleadoCalendar1>();
            EmpleadoCentro1s = new HashSet<EmpleadoCentro1>();
            EmpleadoComprobante1s = new HashSet<EmpleadoComprobante1>();
            EmpleadoConcNomi1s = new HashSet<EmpleadoConcNomi1>();
            EmpleadoConcepto1s = new HashSet<EmpleadoConcepto1>();
            EmpleadoContrato1s = new HashSet<EmpleadoContrato1>();
            EmpleadoDocumento1s = new HashSet<EmpleadoDocumento1>();
            EmpleadoEvaluacio1s = new HashSet<EmpleadoEvaluacio1>();
            EmpleadoJerarquium1SubordinadoNavigations = new HashSet<EmpleadoJerarquium1>();
            EmpleadoJerarquium1SuperiorNavigations = new HashSet<EmpleadoJerarquium1>();
            EmpleadoNomiNeto1s = new HashSet<EmpleadoNomiNeto1>();
            EmpleadoPariente1s = new HashSet<EmpleadoPariente1>();
            EmpleadoSaldoVac1s = new HashSet<EmpleadoSaldoVac1>();
            FiltroEmpleadoReporte1s = new HashSet<FiltroEmpleadoReporte1>();
            GrupoTrabajoPcLinea1s = new HashSet<GrupoTrabajoPcLinea1>();
            HistoricoEmpleado1EmpleadoNavigations = new HashSet<HistoricoEmpleado1>();
            HistoricoEmpleado1JefeNavigations = new HashSet<HistoricoEmpleado1>();
            HoraLaboradum1s = new HashSet<HoraLaboradum1>();
            Liquidacion1s = new HashSet<Liquidacion1>();
            MarcaReloj1s = new HashSet<MarcaReloj1>();
            OpOperDetMo1s = new HashSet<OpOperDetMo1>();
            OrdenProdEmpleado1s = new HashSet<OrdenProdEmpleado1>();
            OrdenTrabajo1EmpSolicitanteNavigations = new HashSet<OrdenTrabajo1>();
            OrdenTrabajo1EmpleadoEntregaNavigations = new HashSet<OrdenTrabajo1>();
            OrdenTrabajo1EmpleadoRecibeNavigations = new HashSet<OrdenTrabajo1>();
            OtPlanTrabajo1s = new HashSet<OtPlanTrabajo1>();
            OtReporteLabor1s = new HashSet<OtReporteLabor1>();
            PilaHistoricoDet1s = new HashSet<PilaHistoricoDet1>();
            Responsable1s = new HashSet<Responsable1>();
            RolEqPrevent1s = new HashSet<RolEqPrevent1>();
            SalDiarioIntDet1s = new HashSet<SalDiarioIntDet1>();
            SalDiarioIntEmp1s = new HashSet<SalDiarioIntEmp1>();
            SolicitudRh1EmpleadoNavigations = new HashSet<SolicitudRh1>();
            SolicitudRh1GeneradaPorNavigations = new HashSet<SolicitudRh1>();
            SolicitudRhNotif1s = new HashSet<SolicitudRhNotif1>();
            SolicitudTrabajo1s = new HashSet<SolicitudTrabajo1>();
            TipoSoliRhNotif1s = new HashSet<TipoSoliRhNotif1>();
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
        public decimal BonoDecreto { get; set; }

        public virtual CentroCosto1 CentroCostoNavigation { get; set; } = null!;
        public virtual ClaseSeguro1? ClaseSeguroNavigation { get; set; }
        public virtual Departamento1 DepartamentoNavigation { get; set; } = null!;
        public virtual DetalleDireccion1? DetalleDirHabNavigation { get; set; }
        public virtual DetalleDireccion1? DetalleDirPostalNavigation { get; set; }
        public virtual EntidadFinanciera1? EntidadFinancieraNavigation { get; set; }
        public virtual EstadoEmpleado1 EstadoEmpleadoNavigation { get; set; } = null!;
        public virtual FormaPagoNe1? FormaPagoNeNavigation { get; set; }
        public virtual Horario1 HorarioNavigation { get; set; } = null!;
        public virtual MedioPagoNe1? MedioPagoNeNavigation { get; set; }
        public virtual Nit1? NitNavigation { get; set; }
        public virtual Nomina1 NominaNavigation { get; set; } = null!;
        public virtual Plaza1 P { get; set; } = null!;
        public virtual Pai1? PaisDirecNavigation { get; set; }
        public virtual Pai1 PaisNavigation { get; set; } = null!;
        public virtual SubtipoTrabajadorNe1? SubtipoTrabajadorNeNavigation { get; set; }
        public virtual TipoCuentum1? TipoCuentaEntidadNavigation { get; set; }
        public virtual TipoTrabajadorNe1? TipoTrabajadorNeNavigation { get; set; }
        public virtual Ubicacion1 UbicacionNavigation { get; set; } = null!;
        public virtual Usuario2? UsuarioCreacionNavigation { get; set; }
        public virtual Usuario2? UsuarioUltModNavigation { get; set; }
        public virtual Cotizante1 Cotizante1 { get; set; } = null!;
        public virtual CsEmpleadoArea CsEmpleadoArea { get; set; } = null!;
        public virtual EmpleadoNota1 EmpleadoNota1 { get; set; } = null!;
        public virtual EmpleadoVacacion1 EmpleadoVacacion1 { get; set; } = null!;
        public virtual ICollection<Adicionalempleado1> Adicionalempleado1s { get; set; }
        public virtual ICollection<AsocHerram1> AsocHerram1s { get; set; }
        public virtual ICollection<BodegaEncargado1> BodegaEncargado1s { get; set; }
        public virtual ICollection<CalcVacDetalle1> CalcVacDetalle1s { get; set; }
        public virtual ICollection<CalculoVacacional1> CalculoVacacional1s { get; set; }
        public virtual ICollection<ControlHorasIncap1> ControlHorasIncap1s { get; set; }
        public virtual ICollection<CreditoEmpleado1> CreditoEmpleado1s { get; set; }
        public virtual ICollection<CsAreaOrg> CsAreaOrgs { get; set; }
        public virtual ICollection<CsEmpleadoHorario> CsEmpleadoHorarios { get; set; }
        public virtual ICollection<CsEstrucMo1> CsEstrucMo1s { get; set; }
        public virtual ICollection<CsMarcada> CsMarcada { get; set; }
        public virtual ICollection<EmpConcLiquidac1> EmpConcLiquidac1s { get; set; }
        public virtual ICollection<EmpExperiencium1> EmpExperiencium1s { get; set; }
        public virtual ICollection<EmpleadoAcademico1> EmpleadoAcademico1s { get; set; }
        public virtual ICollection<EmpleadoAccPer1> EmpleadoAccPer1s { get; set; }
        public virtual ICollection<EmpleadoAccidente1> EmpleadoAccidente1s { get; set; }
        public virtual ICollection<EmpleadoAusencium1> EmpleadoAusencium1s { get; set; }
        public virtual ICollection<EmpleadoCalendar1> EmpleadoCalendar1s { get; set; }
        public virtual ICollection<EmpleadoCentro1> EmpleadoCentro1s { get; set; }
        public virtual ICollection<EmpleadoComprobante1> EmpleadoComprobante1s { get; set; }
        public virtual ICollection<EmpleadoConcNomi1> EmpleadoConcNomi1s { get; set; }
        public virtual ICollection<EmpleadoConcepto1> EmpleadoConcepto1s { get; set; }
        public virtual ICollection<EmpleadoContrato1> EmpleadoContrato1s { get; set; }
        public virtual ICollection<EmpleadoDocumento1> EmpleadoDocumento1s { get; set; }
        public virtual ICollection<EmpleadoEvaluacio1> EmpleadoEvaluacio1s { get; set; }
        public virtual ICollection<EmpleadoJerarquium1> EmpleadoJerarquium1SubordinadoNavigations { get; set; }
        public virtual ICollection<EmpleadoJerarquium1> EmpleadoJerarquium1SuperiorNavigations { get; set; }
        public virtual ICollection<EmpleadoNomiNeto1> EmpleadoNomiNeto1s { get; set; }
        public virtual ICollection<EmpleadoPariente1> EmpleadoPariente1s { get; set; }
        public virtual ICollection<EmpleadoSaldoVac1> EmpleadoSaldoVac1s { get; set; }
        public virtual ICollection<FiltroEmpleadoReporte1> FiltroEmpleadoReporte1s { get; set; }
        public virtual ICollection<GrupoTrabajoPcLinea1> GrupoTrabajoPcLinea1s { get; set; }
        public virtual ICollection<HistoricoEmpleado1> HistoricoEmpleado1EmpleadoNavigations { get; set; }
        public virtual ICollection<HistoricoEmpleado1> HistoricoEmpleado1JefeNavigations { get; set; }
        public virtual ICollection<HoraLaboradum1> HoraLaboradum1s { get; set; }
        public virtual ICollection<Liquidacion1> Liquidacion1s { get; set; }
        public virtual ICollection<MarcaReloj1> MarcaReloj1s { get; set; }
        public virtual ICollection<OpOperDetMo1> OpOperDetMo1s { get; set; }
        public virtual ICollection<OrdenProdEmpleado1> OrdenProdEmpleado1s { get; set; }
        public virtual ICollection<OrdenTrabajo1> OrdenTrabajo1EmpSolicitanteNavigations { get; set; }
        public virtual ICollection<OrdenTrabajo1> OrdenTrabajo1EmpleadoEntregaNavigations { get; set; }
        public virtual ICollection<OrdenTrabajo1> OrdenTrabajo1EmpleadoRecibeNavigations { get; set; }
        public virtual ICollection<OtPlanTrabajo1> OtPlanTrabajo1s { get; set; }
        public virtual ICollection<OtReporteLabor1> OtReporteLabor1s { get; set; }
        public virtual ICollection<PilaHistoricoDet1> PilaHistoricoDet1s { get; set; }
        public virtual ICollection<Responsable1> Responsable1s { get; set; }
        public virtual ICollection<RolEqPrevent1> RolEqPrevent1s { get; set; }
        public virtual ICollection<SalDiarioIntDet1> SalDiarioIntDet1s { get; set; }
        public virtual ICollection<SalDiarioIntEmp1> SalDiarioIntEmp1s { get; set; }
        public virtual ICollection<SolicitudRh1> SolicitudRh1EmpleadoNavigations { get; set; }
        public virtual ICollection<SolicitudRh1> SolicitudRh1GeneradaPorNavigations { get; set; }
        public virtual ICollection<SolicitudRhNotif1> SolicitudRhNotif1s { get; set; }
        public virtual ICollection<SolicitudTrabajo1> SolicitudTrabajo1s { get; set; }
        public virtual ICollection<TipoSoliRhNotif1> TipoSoliRhNotif1s { get; set; }
    }
}
