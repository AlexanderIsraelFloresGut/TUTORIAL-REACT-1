using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class LoteEspe2
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

        public virtual Atributo2 AtributoNavigation { get; set; } = null!;
        public virtual Lote2 Lote2 { get; set; } = null!;
    }
}
