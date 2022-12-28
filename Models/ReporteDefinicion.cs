using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class ReporteDefinicion
    {
        public string Accion { get; set; } = null!;
        public int? Entidad { get; set; }
        public string? DefinicionDatos { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual ReportePersonaliz AccionNavigation { get; set; } = null!;
        public virtual DdEntidad? EntidadNavigation { get; set; }
    }
}
