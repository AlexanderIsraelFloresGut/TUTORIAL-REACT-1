using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class Nomina1
    {
        public Nomina1()
        {
            CalculoVacacional1s = new HashSet<CalculoVacacional1>();
            ConceptoUsuario1s = new HashSet<ConceptoUsuario1>();
            ControlHorasIncap1s = new HashSet<ControlHorasIncap1>();
            Empleado1s = new HashSet<Empleado1>();
            EmpleadoAccPer1s = new HashSet<EmpleadoAccPer1>();
            HistoricoEmpleado1s = new HashSet<HistoricoEmpleado1>();
            NominaBanco1s = new HashSet<NominaBanco1>();
            NominaConcepto1s = new HashSet<NominaConcepto1>();
            NominaHistorico1s = new HashSet<NominaHistorico1>();
            NominaUsuario1s = new HashSet<NominaUsuario1>();
            SalDiarioInt1s = new HashSet<SalDiarioInt1>();
            TipoAccionConcep1s = new HashSet<TipoAccionConcep1>();
        }

        public string Nomina { get; set; } = null!;
        public string? Rubro9 { get; set; }
        public string? CtrNomina { get; set; }
        public string? CtaNomina { get; set; }
        public string Descripcion { get; set; } = null!;
        public string TipoNomina { get; set; } = null!;
        public short Consecutivo { get; set; }
        public string? NumeroPatronal { get; set; }
        public string Estado { get; set; } = null!;
        public string? CuentaBanco { get; set; }
        public string Moneda { get; set; } = null!;
        public string ImpAcumConceptos { get; set; } = null!;
        public string ImpCondConceptos { get; set; } = null!;
        public string EliminarConcCero { get; set; } = null!;
        public string? Rubro1 { get; set; }
        public string? Rubro2 { get; set; }
        public string? Rubro7 { get; set; }
        public string? Rubro6 { get; set; }
        public string? Rubro5 { get; set; }
        public string? Rubro3 { get; set; }
        public string? Rubro4 { get; set; }
        public string? Rubro8 { get; set; }
        public string? Rubro10 { get; set; }
        public short? SubtipodocCheque { get; set; }
        public short? SubtipodocTef { get; set; }
        public string? ModalidadAsiento { get; set; }
        public string? ConceptoTipoCambio { get; set; }
        public string? ConceptoDiasLabor { get; set; }
        public string? Reporte { get; set; }
        public string? PaqueteCr { get; set; }
        public string? PresupuestoCr { get; set; }
        public string InicializarPorPuesto { get; set; } = null!;
        public string? Numserie { get; set; }
        public string EsPila { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
        public string NitCiaAsnt { get; set; } = null!;
        public string? PeriodoNomina { get; set; }
        public string ParticipaNe { get; set; } = null!;

        public virtual Concepto1? ConceptoDiasLaborNavigation { get; set; }
        public virtual Concepto1? ConceptoTipoCambioNavigation { get; set; }
        public virtual CentroCuentum1? Ct { get; set; }
        public virtual CuentaBancarium1? CuentaBancoNavigation { get; set; }
        public virtual Monedum1 MonedaNavigation { get; set; } = null!;
        public virtual PeriodoNomina1? PeriodoNominaNavigation { get; set; }
        public virtual ICollection<CalculoVacacional1> CalculoVacacional1s { get; set; }
        public virtual ICollection<ConceptoUsuario1> ConceptoUsuario1s { get; set; }
        public virtual ICollection<ControlHorasIncap1> ControlHorasIncap1s { get; set; }
        public virtual ICollection<Empleado1> Empleado1s { get; set; }
        public virtual ICollection<EmpleadoAccPer1> EmpleadoAccPer1s { get; set; }
        public virtual ICollection<HistoricoEmpleado1> HistoricoEmpleado1s { get; set; }
        public virtual ICollection<NominaBanco1> NominaBanco1s { get; set; }
        public virtual ICollection<NominaConcepto1> NominaConcepto1s { get; set; }
        public virtual ICollection<NominaHistorico1> NominaHistorico1s { get; set; }
        public virtual ICollection<NominaUsuario1> NominaUsuario1s { get; set; }
        public virtual ICollection<SalDiarioInt1> SalDiarioInt1s { get; set; }
        public virtual ICollection<TipoAccionConcep1> TipoAccionConcep1s { get; set; }
    }
}
