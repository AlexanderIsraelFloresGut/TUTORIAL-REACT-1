using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class TipoIncapacidad2
    {
        public TipoIncapacidad2()
        {
            TipoAccion2s = new HashSet<TipoAccion2>();
        }

        public string TipoIncapacidad { get; set; } = null!;
        public string? Nombre { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual ICollection<TipoAccion2> TipoAccion2s { get; set; }
    }
}
