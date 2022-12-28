using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class Liquidacion1
    {
        public Liquidacion1()
        {
            EmpleadoAccSaldo1s = new HashSet<EmpleadoAccSaldo1>();
            EmpleadoSaldoVac1s = new HashSet<EmpleadoSaldoVac1>();
            LiquidacionAporte1s = new HashSet<LiquidacionAporte1>();
            LiquidacionConcep1s = new HashSet<LiquidacionConcep1>();
            LiquidacionContra1s = new HashSet<LiquidacionContra1>();
        }

        public int Liquidacion { get; set; }
        public string Empleado { get; set; } = null!;
        public string Moneda { get; set; } = null!;
        public string EstadoLiquidac { get; set; } = null!;
        public DateTime FechaIngreso { get; set; }
        public DateTime FechaSalida { get; set; }
        public string CerrarContratos { get; set; } = null!;
        public int NumeroAccion { get; set; }
        public string FormaPago { get; set; } = null!;
        public string? CuentaBanco { get; set; }
        public decimal? NumeroDocPago { get; set; }
        public string? AsientoContable { get; set; }
        public DateTime? FechaRetiroPago { get; set; }
        public string UsuarioUltModi { get; set; } = null!;
        public DateTime FechaUltModi { get; set; }
        public string? UsuarioLiquidac { get; set; }
        public DateTime? FechaLiquidacion { get; set; }
        public string? Observaciones { get; set; }
        public short? SubtipodocPago { get; set; }
        public string? Presupuesto { get; set; }
        public string? UnidadOperativa { get; set; }
        public int? NumeroApartado { get; set; }
        public int? NumeroEjercido { get; set; }
        public string CalculaPagoNomina { get; set; } = null!;
        public string? NominaCalculo { get; set; }
        public short? NumeroNominaCalculo { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual CuentaBancarium1? CuentaBancoNavigation { get; set; }
        public virtual Empleado1 EmpleadoNavigation { get; set; } = null!;
        public virtual Monedum1 MonedaNavigation { get; set; } = null!;
        public virtual EmpleadoAccPer1 NumeroAccionNavigation { get; set; } = null!;
        public virtual Usuario2? UsuarioLiquidacNavigation { get; set; }
        public virtual Usuario2 UsuarioUltModiNavigation { get; set; } = null!;
        public virtual ICollection<EmpleadoAccSaldo1> EmpleadoAccSaldo1s { get; set; }
        public virtual ICollection<EmpleadoSaldoVac1> EmpleadoSaldoVac1s { get; set; }
        public virtual ICollection<LiquidacionAporte1> LiquidacionAporte1s { get; set; }
        public virtual ICollection<LiquidacionConcep1> LiquidacionConcep1s { get; set; }
        public virtual ICollection<LiquidacionContra1> LiquidacionContra1s { get; set; }
    }
}
