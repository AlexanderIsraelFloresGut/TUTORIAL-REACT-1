using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class MetodoValuacionEquiv
    {
        public int MetodoValuacion { get; set; }
        public string ValorCr { get; set; } = null!;
        public string? ValorPe { get; set; }
        public string DescripcionCr { get; set; } = null!;
        public string? DescripcionPe { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
    }
}
