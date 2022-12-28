using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class Nomina2
    {
        public Nomina2()
        {
            CalculoVacacional2s = new HashSet<CalculoVacacional2>();
            ConceptoUsuario2s = new HashSet<ConceptoUsuario2>();
            ControlHorasIncap2s = new HashSet<ControlHorasIncap2>();
            Empleado2s = new HashSet<Empleado2>();
            EmpleadoAccPer2s = new HashSet<EmpleadoAccPer2>();
            HistoricoEmpleado2s = new HashSet<HistoricoEmpleado2>();
            NominaBanco2s = new HashSet<NominaBanco2>();
            NominaConcepto2s = new HashSet<NominaConcepto2>();
            NominaHistorico2s = new HashSet<NominaHistorico2>();
            NominaUsuario2s = new HashSet<NominaUsuario2>();
            SalDiarioInt2s = new HashSet<SalDiarioInt2>();
            TipoAccionConcep2s = new HashSet<TipoAccionConcep2>();
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

        public virtual Concepto2? ConceptoDiasLaborNavigation { get; set; }
        public virtual Concepto2? ConceptoTipoCambioNavigation { get; set; }
        public virtual CentroCuentum2? Ct { get; set; }
        public virtual CuentaBancarium2? CuentaBancoNavigation { get; set; }
        public virtual Monedum2 MonedaNavigation { get; set; } = null!;
        public virtual PeriodoNomina2? PeriodoNominaNavigation { get; set; }
        public virtual ICollection<CalculoVacacional2> CalculoVacacional2s { get; set; }
        public virtual ICollection<ConceptoUsuario2> ConceptoUsuario2s { get; set; }
        public virtual ICollection<ControlHorasIncap2> ControlHorasIncap2s { get; set; }
        public virtual ICollection<Empleado2> Empleado2s { get; set; }
        public virtual ICollection<EmpleadoAccPer2> EmpleadoAccPer2s { get; set; }
        public virtual ICollection<HistoricoEmpleado2> HistoricoEmpleado2s { get; set; }
        public virtual ICollection<NominaBanco2> NominaBanco2s { get; set; }
        public virtual ICollection<NominaConcepto2> NominaConcepto2s { get; set; }
        public virtual ICollection<NominaHistorico2> NominaHistorico2s { get; set; }
        public virtual ICollection<NominaUsuario2> NominaUsuario2s { get; set; }
        public virtual ICollection<SalDiarioInt2> SalDiarioInt2s { get; set; }
        public virtual ICollection<TipoAccionConcep2> TipoAccionConcep2s { get; set; }
    }
}
