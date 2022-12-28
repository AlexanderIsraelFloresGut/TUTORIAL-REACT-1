using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class NominaHistorico2
    {
        public NominaHistorico2()
        {
            EmpleadoAccSaldo2s = new HashSet<EmpleadoAccSaldo2>();
            EmpleadoConcNomi2s = new HashSet<EmpleadoConcNomi2>();
            EmpleadoNomiNeto2s = new HashSet<EmpleadoNomiNeto2>();
            EmpleadoSaldoVac2s = new HashSet<EmpleadoSaldoVac2>();
            HoraLaboradum2s = new HashSet<HoraLaboradum2>();
            PilaHistorico2s = new HashSet<PilaHistorico2>();
            PilaHistoricoDet2s = new HashSet<PilaHistoricoDet2>();
        }

        public string Nomina { get; set; } = null!;
        public short NumeroNomina { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public DateTime Periodo { get; set; }
        public DateTime? FechaAprobacion { get; set; }
        public DateTime FechaPago { get; set; }
        public string? AprobadaPor { get; set; }
        public string? Asiento { get; set; }
        public DateTime? FechaAplicacion { get; set; }
        public string? UsuarioAplicacion { get; set; }
        public DateTime? FechaCalculo { get; set; }
        public string? Presupuesto { get; set; }
        public string? UnidadOperativa { get; set; }
        public int? NumeroApartado { get; set; }
        public int? NumeroEjercido { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual Usuario2? AprobadaPorNavigation { get; set; }
        public virtual Nomina2 NominaNavigation { get; set; } = null!;
        public virtual Usuario2? UsuarioAplicacionNavigation { get; set; }
        public virtual ICollection<EmpleadoAccSaldo2> EmpleadoAccSaldo2s { get; set; }
        public virtual ICollection<EmpleadoConcNomi2> EmpleadoConcNomi2s { get; set; }
        public virtual ICollection<EmpleadoNomiNeto2> EmpleadoNomiNeto2s { get; set; }
        public virtual ICollection<EmpleadoSaldoVac2> EmpleadoSaldoVac2s { get; set; }
        public virtual ICollection<HoraLaboradum2> HoraLaboradum2s { get; set; }
        public virtual ICollection<PilaHistorico2> PilaHistorico2s { get; set; }
        public virtual ICollection<PilaHistoricoDet2> PilaHistoricoDet2s { get; set; }
    }
}
