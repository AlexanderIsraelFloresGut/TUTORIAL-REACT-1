using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class NominaHistorico1
    {
        public NominaHistorico1()
        {
            EmpleadoAccSaldo1s = new HashSet<EmpleadoAccSaldo1>();
            EmpleadoConcNomi1s = new HashSet<EmpleadoConcNomi1>();
            EmpleadoNomiNeto1s = new HashSet<EmpleadoNomiNeto1>();
            EmpleadoSaldoVac1s = new HashSet<EmpleadoSaldoVac1>();
            HoraLaboradum1s = new HashSet<HoraLaboradum1>();
            PilaHistorico1s = new HashSet<PilaHistorico1>();
            PilaHistoricoDet1s = new HashSet<PilaHistoricoDet1>();
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
        public virtual Nomina1 NominaNavigation { get; set; } = null!;
        public virtual Usuario2? UsuarioAplicacionNavigation { get; set; }
        public virtual ICollection<EmpleadoAccSaldo1> EmpleadoAccSaldo1s { get; set; }
        public virtual ICollection<EmpleadoConcNomi1> EmpleadoConcNomi1s { get; set; }
        public virtual ICollection<EmpleadoNomiNeto1> EmpleadoNomiNeto1s { get; set; }
        public virtual ICollection<EmpleadoSaldoVac1> EmpleadoSaldoVac1s { get; set; }
        public virtual ICollection<HoraLaboradum1> HoraLaboradum1s { get; set; }
        public virtual ICollection<PilaHistorico1> PilaHistorico1s { get; set; }
        public virtual ICollection<PilaHistoricoDet1> PilaHistoricoDet1s { get; set; }
    }
}
