using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class CsProduccionEstruc1
    {
        public long IdEstructura { get; set; }
        public string Articulo { get; set; } = null!;
        public decimal? Version { get; set; }
        public decimal? Horas { get; set; }
        public int? Lote { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
    }
}
