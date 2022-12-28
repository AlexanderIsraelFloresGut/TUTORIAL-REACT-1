using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class PaqDescGrupo1
    {
        public string PaqueteDescuento { get; set; } = null!;
        public string Grupo { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual PaqueteDescuento1 PaqueteDescuentoNavigation { get; set; } = null!;
    }
}
