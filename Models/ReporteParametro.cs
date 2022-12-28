using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class ReporteParametro
    {
        public string Accion { get; set; } = null!;
        public string Parametro { get; set; } = null!;
        public string Tipo { get; set; } = null!;
        public string TipoEdicion { get; set; } = null!;
        public string UsadoEnFiltro { get; set; } = null!;
        public string? AliasTabla { get; set; }
        public int? Tamano { get; set; }
        public string? Columna { get; set; }
        public string? Valores { get; set; }
        public string? Tabla { get; set; }
        public string IsFiltroConsulta { get; set; } = null!;
        public string? SentenciaConsulta { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual ReportePersonaliz AccionNavigation { get; set; } = null!;
        public virtual DdTabla? TablaNavigation { get; set; }
    }
}
