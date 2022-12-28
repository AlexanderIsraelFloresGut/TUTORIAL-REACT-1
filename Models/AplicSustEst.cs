using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class AplicSustEst
    {
        public string Estructura { get; set; } = null!;
        public string MatPrimaOrig { get; set; } = null!;
        public string MatSubstituto { get; set; } = null!;
        public string AplicarSust { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
    }
}
