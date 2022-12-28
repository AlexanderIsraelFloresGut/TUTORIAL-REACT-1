using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class EmpleadoConcNomiCalc
    {
        public int Consecutivo { get; set; }
        public string Empleado { get; set; } = null!;
        public string Concepto { get; set; } = null!;
        public string Nomina { get; set; } = null!;
        public short NumeroNomina { get; set; }
        public string CentroCosto { get; set; } = null!;
        public decimal Total { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
    }
}
