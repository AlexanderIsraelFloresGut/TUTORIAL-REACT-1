using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class ReporteUbicacion
    {
        public string Accion { get; set; } = null!;
        public int AccionPadreErp { get; set; }
        public int AccionErp { get; set; }
        public string? Tipo { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual ReportePersonaliz AccionNavigation { get; set; } = null!;
    }
}
