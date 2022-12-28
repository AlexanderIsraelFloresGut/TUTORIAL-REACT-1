using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class TomaActivoControl1
    {
        public string ActivoFijo { get; set; } = null!;
        public string? EstatusActivo { get; set; }
        public int? Nuevo { get; set; }
        public string? CodigoActivo { get; set; }
        public string? PocketId { get; set; }
        public string IdSincro { get; set; } = null!;
        public DateTime? FechaSincro { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
    }
}
