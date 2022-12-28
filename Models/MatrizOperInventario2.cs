using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class MatrizOperInventario2
    {
        public string Tipo { get; set; } = null!;
        public string Subtipo { get; set; } = null!;
        public string Subsubtipo { get; set; } = null!;
        public string Naturaleza { get; set; } = null!;
        public string? TipoOperacion { get; set; }
        public string? TipoPago { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual TipoOperacion2? TipoOperacionNavigation { get; set; }
        public virtual TipoPago2? TipoPagoNavigation { get; set; }
    }
}
