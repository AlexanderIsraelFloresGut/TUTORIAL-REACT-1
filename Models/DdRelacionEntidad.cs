using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class DdRelacionEntidad
    {
        public int Entidad { get; set; }
        public string Tabla { get; set; } = null!;
        public string Alias { get; set; } = null!;
        public string Columna { get; set; } = null!;
        public int EntidadPadre { get; set; }
        public string TablaPadre { get; set; } = null!;
        public string AliasPadre { get; set; } = null!;
        public string ColumnaPadre { get; set; } = null!;
        public string? TipoRelacion { get; set; }
        public string Nombrerelacion { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual DdEntidadTabla DdEntidadTabla { get; set; } = null!;
        public virtual DdEntidadTabla DdEntidadTablaNavigation { get; set; } = null!;
    }
}
