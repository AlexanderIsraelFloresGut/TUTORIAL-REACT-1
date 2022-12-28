using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class EmpleadosXRango1
    {
        public string Empleado { get; set; } = null!;
        public decimal VariableDesicion { get; set; }
        public string CentroCosto { get; set; } = null!;
        public string? Fase { get; set; }
        public string? Proyecto { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
        public int Consecutivo { get; set; }
    }
}
