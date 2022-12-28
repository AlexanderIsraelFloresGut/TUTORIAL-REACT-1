using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class Concepto1
    {
        public Concepto1()
        {
            AdminConcepto1s = new HashSet<AdminConcepto1>();
            CentroConcepto1s = new HashSet<CentroConcepto1>();
            ConcFormConcepto1s = new HashSet<ConcFormConcepto1>();
            ConceptoFormula1s = new HashSet<ConceptoFormula1>();
            ConceptoLiquidac1s = new HashSet<ConceptoLiquidac1>();
            ConceptoPuesto1s = new HashSet<ConceptoPuesto1>();
            ConceptoUsuario1s = new HashSet<ConceptoUsuario1>();
            CreditoEmpleado1s = new HashSet<CreditoEmpleado1>();
            EmpleadoConcepto1s = new HashSet<EmpleadoConcepto1>();
            GrupoConceptoDet1s = new HashSet<GrupoConceptoDet1>();
            HoraLaboradum1s = new HashSet<HoraLaboradum1>();
            HorarioConcepto1s = new HashSet<HorarioConcepto1>();
            Nomina1ConceptoDiasLaborNavigations = new HashSet<Nomina1>();
            Nomina1ConceptoTipoCambioNavigations = new HashSet<Nomina1>();
            NominaConcepto1s = new HashSet<NominaConcepto1>();
            SalDiarioInt1s = new HashSet<SalDiarioInt1>();
            SalDiarioIntCon1s = new HashSet<SalDiarioIntCon1>();
            SalDiarioIntDet1s = new HashSet<SalDiarioIntDet1>();
            TipoAccionConcep1s = new HashSet<TipoAccionConcep1>();
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

        public virtual Cliente1? ClienteNavigation { get; set; }
        public virtual Proveedor1? ProveedorNavigation { get; set; }
        public virtual TipoHoraExtraRecar1? TipoHoraExtraNavigation { get; set; }
        public virtual ICollection<AdminConcepto1> AdminConcepto1s { get; set; }
        public virtual ICollection<CentroConcepto1> CentroConcepto1s { get; set; }
        public virtual ICollection<ConcFormConcepto1> ConcFormConcepto1s { get; set; }
        public virtual ICollection<ConceptoFormula1> ConceptoFormula1s { get; set; }
        public virtual ICollection<ConceptoLiquidac1> ConceptoLiquidac1s { get; set; }
        public virtual ICollection<ConceptoPuesto1> ConceptoPuesto1s { get; set; }
        public virtual ICollection<ConceptoUsuario1> ConceptoUsuario1s { get; set; }
        public virtual ICollection<CreditoEmpleado1> CreditoEmpleado1s { get; set; }
        public virtual ICollection<EmpleadoConcepto1> EmpleadoConcepto1s { get; set; }
        public virtual ICollection<GrupoConceptoDet1> GrupoConceptoDet1s { get; set; }
        public virtual ICollection<HoraLaboradum1> HoraLaboradum1s { get; set; }
        public virtual ICollection<HorarioConcepto1> HorarioConcepto1s { get; set; }
        public virtual ICollection<Nomina1> Nomina1ConceptoDiasLaborNavigations { get; set; }
        public virtual ICollection<Nomina1> Nomina1ConceptoTipoCambioNavigations { get; set; }
        public virtual ICollection<NominaConcepto1> NominaConcepto1s { get; set; }
        public virtual ICollection<SalDiarioInt1> SalDiarioInt1s { get; set; }
        public virtual ICollection<SalDiarioIntCon1> SalDiarioIntCon1s { get; set; }
        public virtual ICollection<SalDiarioIntDet1> SalDiarioIntDet1s { get; set; }
        public virtual ICollection<TipoAccionConcep1> TipoAccionConcep1s { get; set; }
    }
}
