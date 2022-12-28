using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class LoteEspe1
    {
        public string Articulo { get; set; } = null!;
        public string Lote { get; set; } = null!;
        public string Atributo { get; set; } = null!;
        public decimal? ValorReal { get; set; }
        public string? Unidad { get; set; }
        public string? ValorCualitativo { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual Atributo1 AtributoNavigation { get; set; } = null!;
        public virtual Lote1 Lote1 { get; set; } = null!;
    }
}
