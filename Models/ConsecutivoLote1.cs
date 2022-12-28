using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class ConsecutivoLote1
    {
        public string TipoConsec { get; set; } = null!;
        public string? Descripcion { get; set; }
        public string PrefijoLote { get; set; } = null!;
        public string Consecutivo { get; set; } = null!;
        public DateTime RigeHasta { get; set; }
        public string Activo { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
    }
}
