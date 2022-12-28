using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class Concepto
    {
        public Concepto()
        {
            AdminConceptos = new HashSet<AdminConcepto>();
            CentroConceptos = new HashSet<CentroConcepto>();
            ConcFormConceptos = new HashSet<ConcFormConcepto>();
            ConceptoFormulas = new HashSet<ConceptoFormula>();
            ConceptoLiquidacs = new HashSet<ConceptoLiquidac>();
            ConceptoPuestos = new HashSet<ConceptoPuesto>();
            ConceptoUsuarios = new HashSet<ConceptoUsuario>();
            CreditoEmpleados = new HashSet<CreditoEmpleado>();
            EmpleadoConceptos = new HashSet<EmpleadoConcepto>();
            GrupoConceptoDets = new HashSet<GrupoConceptoDet>();
            HoraLaborada = new HashSet<HoraLaboradum>();
            HorarioConceptos = new HashSet<HorarioConcepto>();
            NominaConceptoDiasLaborNavigations = new HashSet<Nomina>();
            NominaConceptoTipoCambioNavigations = new HashSet<Nomina>();
            NominaConceptos = new HashSet<NominaConcepto>();
            SalDiarioIntCons = new HashSet<SalDiarioIntCon>();
            SalDiarioIntDets = new HashSet<SalDiarioIntDet>();
            SalDiarioInts = new HashSet<SalDiarioInt>();
            TipoAccionConceps = new HashSet<TipoAccionConcep>();
        }

        public string Concepto1 { get; set; } = null!;
        public string Alias { get; set; } = null!;
        public string TipoConcepto { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public string? Unidades { get; set; }
        public string Salarial { get; set; } = null!;
        public string Fijo { get; set; } = null!;
        public string Liquidable { get; set; } = null!;
        public string Excluyente { get; set; } = null!;
        public string? VariableDecision { get; set; }
        public string CantEditable { get; set; } = null!;
        public string MontoEditable { get; set; } = null!;
        public string UsaCantidad { get; set; } = null!;
        public string UsaMonto { get; set; } = null!;
        public string Periodicidad { get; set; } = null!;
        public short DiasPeriodo { get; set; }
        public short MaxNivel { get; set; }
        public string CargaPorDll { get; set; } = null!;
        public string CalculoPorDll { get; set; } = null!;
        public decimal FactorRedondeo { get; set; }
        public string FormulaDefinida { get; set; } = null!;
        public string ImprimirCompPago { get; set; } = null!;
        public string ImprimirAcumulado { get; set; } = null!;
        public string ImprimirCondPago { get; set; } = null!;
        public string EliminarConcCero { get; set; } = null!;
        public string SdiCalcAcumulado { get; set; } = null!;
        public string SdiCalcFormula { get; set; } = null!;
        public string DistribuyeCentros { get; set; } = null!;
        public string? Proveedor { get; set; }
        public string CargaHoras { get; set; } = null!;
        public string IncluirDocRh { get; set; } = null!;
        public string? Notas { get; set; }
        public string CalculoSpd { get; set; } = null!;
        public string? CodigoAnexo { get; set; }
        public DateTime? PeriodoInicialExcluyente { get; set; }
        public DateTime? PeriodoFinalExcluyente { get; set; }
        public string OmitirMontCantCero { get; set; } = null!;
        public string? FuncionInterfaz { get; set; }
        public string? Contabilizacion { get; set; }
        public string? Nit { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
        public string? Cliente { get; set; }
        public string? TipoHoraExtra { get; set; }

        public virtual Cliente? ClienteNavigation { get; set; }
        public virtual Proveedor? ProveedorNavigation { get; set; }
        public virtual TipoHoraExtraRecar? TipoHoraExtraNavigation { get; set; }
        public virtual ICollection<AdminConcepto> AdminConceptos { get; set; }
        public virtual ICollection<CentroConcepto> CentroConceptos { get; set; }
        public virtual ICollection<ConcFormConcepto> ConcFormConceptos { get; set; }
        public virtual ICollection<ConceptoFormula> ConceptoFormulas { get; set; }
        public virtual ICollection<ConceptoLiquidac> ConceptoLiquidacs { get; set; }
        public virtual ICollection<ConceptoPuesto> ConceptoPuestos { get; set; }
        public virtual ICollection<ConceptoUsuario> ConceptoUsuarios { get; set; }
        public virtual ICollection<CreditoEmpleado> CreditoEmpleados { get; set; }
        public virtual ICollection<EmpleadoConcepto> EmpleadoConceptos { get; set; }
        public virtual ICollection<GrupoConceptoDet> GrupoConceptoDets { get; set; }
        public virtual ICollection<HoraLaboradum> HoraLaborada { get; set; }
        public virtual ICollection<HorarioConcepto> HorarioConceptos { get; set; }
        public virtual ICollection<Nomina> NominaConceptoDiasLaborNavigations { get; set; }
        public virtual ICollection<Nomina> NominaConceptoTipoCambioNavigations { get; set; }
        public virtual ICollection<NominaConcepto> NominaConceptos { get; set; }
        public virtual ICollection<SalDiarioIntCon> SalDiarioIntCons { get; set; }
        public virtual ICollection<SalDiarioIntDet> SalDiarioIntDets { get; set; }
        public virtual ICollection<SalDiarioInt> SalDiarioInts { get; set; }
        public virtual ICollection<TipoAccionConcep> TipoAccionConceps { get; set; }
    }
}
