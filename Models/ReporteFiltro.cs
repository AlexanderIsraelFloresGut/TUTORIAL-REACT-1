using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class ReporteFiltro
    {
        public string Accion { get; set; } = null!;
        public string Tabla { get; set; } = null!;
        public string Alias { get; set; } = null!;
        public string Columna { get; set; } = null!;
        public string Tipo { get; set; } = null!;
        public string FiltraBd { get; set; } = null!;
        public string TipoFiltrado { get; set; } = null!;
        public string? Configuracion { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual ReportePersonaliz AccionNavigation { get; set; } = null!;
    }
}
