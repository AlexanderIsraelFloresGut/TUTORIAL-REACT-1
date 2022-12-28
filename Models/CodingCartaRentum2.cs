using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class CodingCartaRentum2
    {
        public string CodIngreso { get; set; } = null!;
        public string? Concepto { get; set; }
        public string? Rubro { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual CodIngreso2 CodIngresoNavigation { get; set; } = null!;
    }
}
