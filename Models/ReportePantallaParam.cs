using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class ReportePantallaParam
    {
        public string Accion { get; set; } = null!;
        public int? AnchoVentana { get; set; }
        public int? AltoVentana { get; set; }
        public string? Estado { get; set; }
        public string? Diseno { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual ReportePersonaliz AccionNavigation { get; set; } = null!;
    }
}
