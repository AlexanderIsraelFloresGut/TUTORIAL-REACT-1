using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class EmpleadoConcNomiTemp1
    {
        public int Consecutivo { get; set; }
        public string Empleado { get; set; } = null!;
        public string Concepto { get; set; } = null!;
        public string Nomina { get; set; } = null!;
        public short NumeroNomina { get; set; }
        public string CentroCosto { get; set; } = null!;
        public string FormaAplicacion { get; set; } = null!;
        public decimal Cantidad { get; set; }
        public decimal Monto { get; set; }
        public decimal Total { get; set; }
        public short? NumeroLiquidac { get; set; }
        public string? Usuario { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public string? Fase { get; set; }
        public string? Proyecto { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
    }
}
