using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class PaqDescRegDesc
    {
        public string PaqueteDescuento { get; set; } = null!;
        public int ReglaDescuento { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual PaqueteDescuento PaqueteDescuentoNavigation { get; set; } = null!;
        public virtual ReglaDescuento ReglaDescuentoNavigation { get; set; } = null!;
    }
}
