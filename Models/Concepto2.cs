using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class Concepto2
    {
        public Concepto2()
        {
            AdminConcepto2s = new HashSet<AdminConcepto2>();
            CentroConcepto2s = new HashSet<CentroConcepto2>();
            ConcFormConcepto2s = new HashSet<ConcFormConcepto2>();
            ConceptoFormula2s = new HashSet<ConceptoFormula2>();
            ConceptoLiquidac2s = new HashSet<ConceptoLiquidac2>();
            ConceptoPuesto2s = new HashSet<ConceptoPuesto2>();
            ConceptoUsuario2s = new HashSet<ConceptoUsuario2>();
            CreditoEmpleado2s = new HashSet<CreditoEmpleado2>();
            EmpleadoConcepto2s = new HashSet<EmpleadoConcepto2>();
            GrupoConceptoDet2s = new HashSet<GrupoConceptoDet2>();
            HoraLaboradum2s = new HashSet<HoraLaboradum2>();
            HorarioConcepto2s = new HashSet<HorarioConcepto2>();
            Nomina2ConceptoDiasLaborNavigations = new HashSet<Nomina2>();
            Nomina2ConceptoTipoCambioNavigations = new HashSet<Nomina2>();
            NominaConcepto2s = new HashSet<NominaConcepto2>();
            SalDiarioInt2s = new HashSet<SalDiarioInt2>();
            SalDiarioIntCon2s = new HashSet<SalDiarioIntCon2>();
            SalDiarioIntDet2s = new HashSet<SalDiarioIntDet2>();
            TipoAccionConcep2s = new HashSet<TipoAccionConcep2>();
        }

        public string Concepto { get; set; } = null!;
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

        public virtual Cliente2? ClienteNavigation { get; set; }
        public virtual Proveedor2? ProveedorNavigation { get; set; }
        public virtual TipoHoraExtraRecar2? TipoHoraExtraNavigation { get; set; }
        public virtual ICollection<AdminConcepto2> AdminConcepto2s { get; set; }
        public virtual ICollection<CentroConcepto2> CentroConcepto2s { get; set; }
        public virtual ICollection<ConcFormConcepto2> ConcFormConcepto2s { get; set; }
        public virtual ICollection<ConceptoFormula2> ConceptoFormula2s { get; set; }
        public virtual ICollection<ConceptoLiquidac2> ConceptoLiquidac2s { get; set; }
        public virtual ICollection<ConceptoPuesto2> ConceptoPuesto2s { get; set; }
        public virtual ICollection<ConceptoUsuario2> ConceptoUsuario2s { get; set; }
        public virtual ICollection<CreditoEmpleado2> CreditoEmpleado2s { get; set; }
        public virtual ICollection<EmpleadoConcepto2> EmpleadoConcepto2s { get; set; }
        public virtual ICollection<GrupoConceptoDet2> GrupoConceptoDet2s { get; set; }
        public virtual ICollection<HoraLaboradum2> HoraLaboradum2s { get; set; }
        public virtual ICollection<HorarioConcepto2> HorarioConcepto2s { get; set; }
        public virtual ICollection<Nomina2> Nomina2ConceptoDiasLaborNavigations { get; set; }
        public virtual ICollection<Nomina2> Nomina2ConceptoTipoCambioNavigations { get; set; }
        public virtual ICollection<NominaConcepto2> NominaConcepto2s { get; set; }
        public virtual ICollection<SalDiarioInt2> SalDiarioInt2s { get; set; }
        public virtual ICollection<SalDiarioIntCon2> SalDiarioIntCon2s { get; set; }
        public virtual ICollection<SalDiarioIntDet2> SalDiarioIntDet2s { get; set; }
        public virtual ICollection<TipoAccionConcep2> TipoAccionConcep2s { get; set; }
    }
}
