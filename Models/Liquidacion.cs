using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class Liquidacion
    {
        public Liquidacion()
        {
            EmpleadoAccSaldos = new HashSet<EmpleadoAccSaldo>();
            EmpleadoSaldoVacs = new HashSet<EmpleadoSaldoVac>();
            LiquidacionAportes = new HashSet<LiquidacionAporte>();
            LiquidacionConceps = new HashSet<LiquidacionConcep>();
            LiquidacionContras = new HashSet<LiquidacionContra>();
        }

        public int Liquidacion1 { get; set; }
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

        public virtual CuentaBancarium? CuentaBancoNavigation { get; set; }
        public virtual Empleado EmpleadoNavigation { get; set; } = null!;
        public virtual Monedum MonedaNavigation { get; set; } = null!;
        public virtual EmpleadoAccPer NumeroAccionNavigation { get; set; } = null!;
        public virtual Usuario2? UsuarioLiquidacNavigation { get; set; }
        public virtual Usuario2 UsuarioUltModiNavigation { get; set; } = null!;
        public virtual ICollection<EmpleadoAccSaldo> EmpleadoAccSaldos { get; set; }
        public virtual ICollection<EmpleadoSaldoVac> EmpleadoSaldoVacs { get; set; }
        public virtual ICollection<LiquidacionAporte> LiquidacionAportes { get; set; }
        public virtual ICollection<LiquidacionConcep> LiquidacionConceps { get; set; }
        public virtual ICollection<LiquidacionContra> LiquidacionContras { get; set; }
    }
}
