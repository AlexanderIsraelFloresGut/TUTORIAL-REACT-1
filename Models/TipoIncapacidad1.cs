using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class TipoIncapacidad1
    {
        public TipoIncapacidad1()
        {
            TipoAccion1s = new HashSet<TipoAccion1>();
        }

        public string TipoIncapacidad { get; set; } = null!;
        public string? Nombre { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual ICollection<TipoAccion1> TipoAccion1s { get; set; }
    }
}
