using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class EmpleadoConcepto2
    {
        public string Empleado { get; set; } = null!;
        public string Concepto { get; set; } = null!;
        public string Activo { get; set; } = null!;
        public string FormaAplicacion { get; set; } = null!;
        public short NumeroCuotas { get; set; }
        public short CuotasAplicadas { get; set; }
        public decimal SaldoInicial { get; set; }
        public decimal Saldo { get; set; }
        public decimal Acumulado { get; set; }
        public DateTime FechaUltAplic { get; set; }
        public DateTime FechaProxAplic { get; set; }
        public DateTime FechaVence { get; set; }
        public decimal Cantidad { get; set; }
        public decimal Monto { get; set; }
        public string Verificado { get; set; } = null!;
        public string? Notas { get; set; }
        public string? PeriodicLiqProv { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual Concepto2 ConceptoNavigation { get; set; } = null!;
        public virtual Empleado2 EmpleadoNavigation { get; set; } = null!;
    }
}
