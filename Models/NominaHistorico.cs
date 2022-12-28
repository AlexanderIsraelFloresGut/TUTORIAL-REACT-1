using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class NominaHistorico
    {
        public NominaHistorico()
        {
            EmpleadoAccSaldos = new HashSet<EmpleadoAccSaldo>();
            EmpleadoConcNomis = new HashSet<EmpleadoConcNomi>();
            EmpleadoNomiNetos = new HashSet<EmpleadoNomiNeto>();
            EmpleadoSaldoVacs = new HashSet<EmpleadoSaldoVac>();
            HoraLaborada = new HashSet<HoraLaboradum>();
            PilaHistoricoDets = new HashSet<PilaHistoricoDet>();
            PilaHistoricos = new HashSet<PilaHistorico>();
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
        public virtual Nomina NominaNavigation { get; set; } = null!;
        public virtual Usuario2? UsuarioAplicacionNavigation { get; set; }
        public virtual ICollection<EmpleadoAccSaldo> EmpleadoAccSaldos { get; set; }
        public virtual ICollection<EmpleadoConcNomi> EmpleadoConcNomis { get; set; }
        public virtual ICollection<EmpleadoNomiNeto> EmpleadoNomiNetos { get; set; }
        public virtual ICollection<EmpleadoSaldoVac> EmpleadoSaldoVacs { get; set; }
        public virtual ICollection<HoraLaboradum> HoraLaborada { get; set; }
        public virtual ICollection<PilaHistoricoDet> PilaHistoricoDets { get; set; }
        public virtual ICollection<PilaHistorico> PilaHistoricos { get; set; }
    }
}
