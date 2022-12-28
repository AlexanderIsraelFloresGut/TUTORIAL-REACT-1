using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class DdRelacionEntidadTabla
    {
        public int Entidad { get; set; }
        public string Tabla { get; set; } = null!;
        public string Alias { get; set; } = null!;
        public string Columna { get; set; } = null!;
        public string TablaRelacion { get; set; } = null!;
        public string AliasRelacion { get; set; } = null!;
        public string ColumnaRelacion { get; set; } = null!;
        public string? Tipo { get; set; }
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
