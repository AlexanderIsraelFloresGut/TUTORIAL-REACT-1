using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class CreditoEmpleado2
    {
        public string Empleado { get; set; } = null!;
        public int NumeroCredito { get; set; }
        public string Concepto { get; set; } = null!;
        public string? Proveedor { get; set; }
        public string Estado { get; set; } = null!;
        public string? RazonEstado { get; set; }
        public int? RefinanciadoCon { get; set; }
        public decimal SaldoInicial { get; set; }
        public decimal SaldoActual { get; set; }
        public string? CuentaBancaria { get; set; }
        public string EntidadFinanciera { get; set; } = null!;
        public DateTime InicioCobro { get; set; }
        public int Prioridad { get; set; }
        public string? MesesNoCobro { get; set; }
        public int Periodicidad { get; set; }
        public int? Dias { get; set; }
        public string? ListaNominas { get; set; }
        public decimal? MontoCobro1 { get; set; }
        public decimal? MontoCobro2 { get; set; }
        public decimal? MontoCobro3 { get; set; }
        public decimal? MontoCobro4 { get; set; }
        public decimal? MontoCobro5 { get; set; }
        public decimal? MontoCobro6 { get; set; }
        public string? DocumentoCc { get; set; }
        public string? TipoDocCc { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual Concepto2 ConceptoNavigation { get; set; } = null!;
        public virtual Empleado2 EmpleadoNavigation { get; set; } = null!;
        public virtual EntidadFinanciera2 EntidadFinancieraNavigation { get; set; } = null!;
    }
}
