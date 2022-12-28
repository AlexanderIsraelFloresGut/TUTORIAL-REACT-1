using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class GlobalesCv
    {
        public string SaldoVacAnno { get; set; } = null!;
        public string CalculoDiasVac { get; set; } = null!;
        public int? UltimaSolicitud { get; set; }
        public string? ControlIncap { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
    }
}
