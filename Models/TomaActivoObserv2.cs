using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class TomaActivoObserv2
    {
        public TomaActivoObserv2()
        {
            TomaActivoAccion2s = new HashSet<TomaActivoAccion2>();
        }

        public string ActivoObservacion { get; set; } = null!;
        public string? Descripcion { get; set; }
        public int? TipoObservacion { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual ICollection<TomaActivoAccion2> TomaActivoAccion2s { get; set; }
    }
}
