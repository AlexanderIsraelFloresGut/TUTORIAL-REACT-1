using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class Empleado
    {
        public Empleado()
        {
            Adicionalempleados = new HashSet<Adicionalempleado>();
            AsocHerrams = new HashSet<AsocHerram>();
            BodegaEncargados = new HashSet<BodegaEncargado>();
            CalcVacDetalles = new HashSet<CalcVacDetalle>();
            CalculoVacacionals = new HashSet<CalculoVacacional>();
            ControlHorasIncaps = new HashSet<ControlHorasIncap>();
            CreditoEmpleados = new HashSet<CreditoEmpleado>();
            CsEstrucMos = new HashSet<CsEstrucMo>();
            EmpConcLiquidacs = new HashSet<EmpConcLiquidac>();
            EmpExperiencia = new HashSet<EmpExperiencium>();
            EmpleadoAcademicos = new HashSet<EmpleadoAcademico>();
            EmpleadoAccPers = new HashSet<EmpleadoAccPer>();
            EmpleadoAccidentes = new HashSet<EmpleadoAccidente>();
            EmpleadoAusencia = new HashSet<EmpleadoAusencium>();
            EmpleadoCalendars = new HashSet<EmpleadoCalendar>();
            EmpleadoCentros = new HashSet<EmpleadoCentro>();
            EmpleadoComprobantes = new HashSet<EmpleadoComprobante>();
            EmpleadoConcNomis = new HashSet<EmpleadoConcNomi>();
            EmpleadoConceptos = new HashSet<EmpleadoConcepto>();
            EmpleadoContratos = new HashSet<EmpleadoContrato>();
            EmpleadoDocumentos = new HashSet<EmpleadoDocumento>();
            EmpleadoEvaluacios = new HashSet<EmpleadoEvaluacio>();
            EmpleadoJerarquiumSubordinadoNavigations = new HashSet<EmpleadoJerarquium>();
            EmpleadoJerarquiumSuperiorNavigations = new HashSet<EmpleadoJerarquium>();
            EmpleadoNomiNetos = new HashSet<EmpleadoNomiNeto>();
            EmpleadoParientes = new HashSet<EmpleadoPariente>();
            EmpleadoSaldoVacs = new HashSet<EmpleadoSaldoVac>();
            FiltroEmpleadoReportes = new HashSet<FiltroEmpleadoReporte>();
            GrupoTrabajoPcLineas = new HashSet<GrupoTrabajoPcLinea>();
            HistoricoEmpleadoEmpleadoNavigations = new HashSet<HistoricoEmpleado>();
            HistoricoEmpleadoJefeNavigations = new HashSet<HistoricoEmpleado>();
            HoraLaborada = new HashSet<HoraLaboradum>();
            Liquidacions = new HashSet<Liquidacion>();
            MarcaRelojs = new HashSet<MarcaReloj>();
            OpOperDetMos = new HashSet<OpOperDetMo>();
            OrdenProdEmpleados = new HashSet<OrdenProdEmpleado>();
            OrdenTrabajoEmpSolicitanteNavigations = new HashSet<OrdenTrabajo>();
            OrdenTrabajoEmpleadoEntregaNavigations = new HashSet<OrdenTrabajo>();
            OrdenTrabajoEmpleadoRecibeNavigations = new HashSet<OrdenTrabajo>();
            OtPlanTrabajos = new HashSet<OtPlanTrabajo>();
            OtReporteLabors = new HashSet<OtReporteLabor>();
            PilaHistoricoDets = new HashSet<PilaHistoricoDet>();
            RolEqPrevents = new HashSet<RolEqPrevent>();
            SalDiarioIntDets = new HashSet<SalDiarioIntDet>();
            SalDiarioIntEmps = new HashSet<SalDiarioIntEmp>();
            SolicitudRhEmpleadoNavigations = new HashSet<SolicitudRh>();
            SolicitudRhGeneradaPorNavigations = new HashSet<SolicitudRh>();
            SolicitudRhNotifs = new HashSet<SolicitudRhNotif>();
            SolicitudTrabajos = new HashSet<SolicitudTrabajo>();
            TipoSoliRhNotifs = new HashSet<TipoSoliRhNotif>();
        }

        public string Empleado1 { get; set; } = null!;
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
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
        public int? TipoMedidasCertificadas { get; set; }
        public int? TipoNivelEducativo { get; set; }
        public string? UTdep { get; set; }
        public string? UCodSucursal { get; set; }
        public string? UTipoPlanilla { get; set; }
        public string? TipoTrabajadorNe { get; set; }
        public string? SubtipoTrabajadorNe { get; set; }
        public string? FormaPagoNe { get; set; }
        public string? MedioPagoNe { get; set; }

        public virtual CentroCosto CentroCostoNavigation { get; set; } = null!;
        public virtual ClaseSeguro? ClaseSeguroNavigation { get; set; }
        public virtual Departamento DepartamentoNavigation { get; set; } = null!;
        public virtual DetalleDireccion? DetalleDirHabNavigation { get; set; }
        public virtual DetalleDireccion? DetalleDirPostalNavigation { get; set; }
        public virtual EntidadFinanciera? EntidadFinancieraNavigation { get; set; }
        public virtual EstadoEmpleado EstadoEmpleadoNavigation { get; set; } = null!;
        public virtual FormaPagoNe? FormaPagoNeNavigation { get; set; }
        public virtual Horario HorarioNavigation { get; set; } = null!;
        public virtual MedioPagoNe? MedioPagoNeNavigation { get; set; }
        public virtual Nit? NitNavigation { get; set; }
        public virtual Nomina NominaNavigation { get; set; } = null!;
        public virtual Plaza P { get; set; } = null!;
        public virtual Pai? PaisDirecNavigation { get; set; }
        public virtual Pai PaisNavigation { get; set; } = null!;
        public virtual SubtipoTrabajadorNe? SubtipoTrabajadorNeNavigation { get; set; }
        public virtual TipoCuentum? TipoCuentaEntidadNavigation { get; set; }
        public virtual TipoTrabajadorNe? TipoTrabajadorNeNavigation { get; set; }
        public virtual Ubicacion UbicacionNavigation { get; set; } = null!;
        public virtual Usuario2? UsuarioCreacionNavigation { get; set; }
        public virtual Usuario2? UsuarioUltModNavigation { get; set; }
        public virtual Cotizante Cotizante { get; set; } = null!;
        public virtual EmpleadoNota EmpleadoNota { get; set; } = null!;
        public virtual EmpleadoVacacion EmpleadoVacacion { get; set; } = null!;
        public virtual ICollection<Adicionalempleado> Adicionalempleados { get; set; }
        public virtual ICollection<AsocHerram> AsocHerrams { get; set; }
        public virtual ICollection<BodegaEncargado> BodegaEncargados { get; set; }
        public virtual ICollection<CalcVacDetalle> CalcVacDetalles { get; set; }
        public virtual ICollection<CalculoVacacional> CalculoVacacionals { get; set; }
        public virtual ICollection<ControlHorasIncap> ControlHorasIncaps { get; set; }
        public virtual ICollection<CreditoEmpleado> CreditoEmpleados { get; set; }
        public virtual ICollection<CsEstrucMo> CsEstrucMos { get; set; }
        public virtual ICollection<EmpConcLiquidac> EmpConcLiquidacs { get; set; }
        public virtual ICollection<EmpExperiencium> EmpExperiencia { get; set; }
        public virtual ICollection<EmpleadoAcademico> EmpleadoAcademicos { get; set; }
        public virtual ICollection<EmpleadoAccPer> EmpleadoAccPers { get; set; }
        public virtual ICollection<EmpleadoAccidente> EmpleadoAccidentes { get; set; }
        public virtual ICollection<EmpleadoAusencium> EmpleadoAusencia { get; set; }
        public virtual ICollection<EmpleadoCalendar> EmpleadoCalendars { get; set; }
        public virtual ICollection<EmpleadoCentro> EmpleadoCentros { get; set; }
        public virtual ICollection<EmpleadoComprobante> EmpleadoComprobantes { get; set; }
        public virtual ICollection<EmpleadoConcNomi> EmpleadoConcNomis { get; set; }
        public virtual ICollection<EmpleadoConcepto> EmpleadoConceptos { get; set; }
        public virtual ICollection<EmpleadoContrato> EmpleadoContratos { get; set; }
        public virtual ICollection<EmpleadoDocumento> EmpleadoDocumentos { get; set; }
        public virtual ICollection<EmpleadoEvaluacio> EmpleadoEvaluacios { get; set; }
        public virtual ICollection<EmpleadoJerarquium> EmpleadoJerarquiumSubordinadoNavigations { get; set; }
        public virtual ICollection<EmpleadoJerarquium> EmpleadoJerarquiumSuperiorNavigations { get; set; }
        public virtual ICollection<EmpleadoNomiNeto> EmpleadoNomiNetos { get; set; }
        public virtual ICollection<EmpleadoPariente> EmpleadoParientes { get; set; }
        public virtual ICollection<EmpleadoSaldoVac> EmpleadoSaldoVacs { get; set; }
        public virtual ICollection<FiltroEmpleadoReporte> FiltroEmpleadoReportes { get; set; }
        public virtual ICollection<GrupoTrabajoPcLinea> GrupoTrabajoPcLineas { get; set; }
        public virtual ICollection<HistoricoEmpleado> HistoricoEmpleadoEmpleadoNavigations { get; set; }
        public virtual ICollection<HistoricoEmpleado> HistoricoEmpleadoJefeNavigations { get; set; }
        public virtual ICollection<HoraLaboradum> HoraLaborada { get; set; }
        public virtual ICollection<Liquidacion> Liquidacions { get; set; }
        public virtual ICollection<MarcaReloj> MarcaRelojs { get; set; }
        public virtual ICollection<OpOperDetMo> OpOperDetMos { get; set; }
        public virtual ICollection<OrdenProdEmpleado> OrdenProdEmpleados { get; set; }
        public virtual ICollection<OrdenTrabajo> OrdenTrabajoEmpSolicitanteNavigations { get; set; }
        public virtual ICollection<OrdenTrabajo> OrdenTrabajoEmpleadoEntregaNavigations { get; set; }
        public virtual ICollection<OrdenTrabajo> OrdenTrabajoEmpleadoRecibeNavigations { get; set; }
        public virtual ICollection<OtPlanTrabajo> OtPlanTrabajos { get; set; }
        public virtual ICollection<OtReporteLabor> OtReporteLabors { get; set; }
        public virtual ICollection<PilaHistoricoDet> PilaHistoricoDets { get; set; }
        public virtual ICollection<RolEqPrevent> RolEqPrevents { get; set; }
        public virtual ICollection<SalDiarioIntDet> SalDiarioIntDets { get; set; }
        public virtual ICollection<SalDiarioIntEmp> SalDiarioIntEmps { get; set; }
        public virtual ICollection<SolicitudRh> SolicitudRhEmpleadoNavigations { get; set; }
        public virtual ICollection<SolicitudRh> SolicitudRhGeneradaPorNavigations { get; set; }
        public virtual ICollection<SolicitudRhNotif> SolicitudRhNotifs { get; set; }
        public virtual ICollection<SolicitudTrabajo> SolicitudTrabajos { get; set; }
        public virtual ICollection<TipoSoliRhNotif> TipoSoliRhNotifs { get; set; }
    }
}
