using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class ProcArticulo
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

        public virtual Articulo ArticuloNavigation { get; set; } = null!;
        public virtual Procedimiento ProcedimientoNavigation { get; set; } = null!;
    }
}
