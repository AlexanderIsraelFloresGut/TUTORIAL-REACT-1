using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class Nomina
    {
        public Nomina()
        {
            CalculoVacacionals = new HashSet<CalculoVacacional>();
            ConceptoUsuarios = new HashSet<ConceptoUsuario>();
            ControlHorasIncaps = new HashSet<ControlHorasIncap>();
            EmpleadoAccPers = new HashSet<EmpleadoAccPer>();
            Empleados = new HashSet<Empleado>();
            HistoricoEmpleados = new HashSet<HistoricoEmpleado>();
            NominaBancos = new HashSet<NominaBanco>();
            NominaConceptos = new HashSet<NominaConcepto>();
            NominaHistoricos = new HashSet<NominaHistorico>();
            NominaUsuarios = new HashSet<NominaUsuario>();
            SalDiarioInts = new HashSet<SalDiarioInt>();
            TipoAccionConceps = new HashSet<TipoAccionConcep>();
        }

        public string Nomina1 { get; set; } = null!;
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
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
        public string EsPila { get; set; } = null!;
        public string NitCiaAsnt { get; set; } = null!;
        public string? PeriodoNomina { get; set; }

        public virtual Concepto? ConceptoDiasLaborNavigation { get; set; }
        public virtual Concepto? ConceptoTipoCambioNavigation { get; set; }
        public virtual CentroCuentum? Ct { get; set; }
        public virtual CuentaBancarium? CuentaBancoNavigation { get; set; }
        public virtual Monedum MonedaNavigation { get; set; } = null!;
        public virtual PeriodoNomina? PeriodoNominaNavigation { get; set; }
        public virtual ICollection<CalculoVacacional> CalculoVacacionals { get; set; }
        public virtual ICollection<ConceptoUsuario> ConceptoUsuarios { get; set; }
        public virtual ICollection<ControlHorasIncap> ControlHorasIncaps { get; set; }
        public virtual ICollection<EmpleadoAccPer> EmpleadoAccPers { get; set; }
        public virtual ICollection<Empleado> Empleados { get; set; }
        public virtual ICollection<HistoricoEmpleado> HistoricoEmpleados { get; set; }
        public virtual ICollection<NominaBanco> NominaBancos { get; set; }
        public virtual ICollection<NominaConcepto> NominaConceptos { get; set; }
        public virtual ICollection<NominaHistorico> NominaHistoricos { get; set; }
        public virtual ICollection<NominaUsuario> NominaUsuarios { get; set; }
        public virtual ICollection<SalDiarioInt> SalDiarioInts { get; set; }
        public virtual ICollection<TipoAccionConcep> TipoAccionConceps { get; set; }
    }
}
