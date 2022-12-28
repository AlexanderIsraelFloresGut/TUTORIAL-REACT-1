using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class OrdenViewit
    {
        public string OrdenProduccion { get; set; } = null!;
        public short Consecutivo { get; set; }
        public string? Viewit { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual OrdenProduccion OrdenProduccionNavigation { get; set; } = null!;
    }
}
