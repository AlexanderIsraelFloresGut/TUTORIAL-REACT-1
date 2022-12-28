using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class ProcArticulo1
    {
        public string Procedimiento { get; set; } = null!;
        public string Version { get; set; } = null!;
        public short Consecutivo { get; set; }
        public short Secuencia { get; set; }
        public string Articulo { get; set; } = null!;
        public decimal CantidadEstimada { get; set; }
        public string Proposito { get; set; } = null!;
        public string? Comentario { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual Articulo1 ArticuloNavigation { get; set; } = null!;
        public virtual Procedimiento1 Procedimiento1 { get; set; } = null!;
    }
}
