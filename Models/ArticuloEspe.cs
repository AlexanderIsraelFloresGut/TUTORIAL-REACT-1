using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class ArticuloEspe
    {
        public string Atributo { get; set; } = null!;
        public string Articulo { get; set; } = null!;
        public decimal Maxima { get; set; }
        public decimal Minima { get; set; }
        public decimal Normal { get; set; }
        public string Unidad { get; set; } = null!;
        public string Valor { get; set; } = null!;
        public string? Notas { get; set; }
        public string ChequearIngreso { get; set; } = null!;
        public string HeredarLotes { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual AliasProduccion ArticuloNavigation { get; set; } = null!;
        public virtual Atributo AtributoNavigation { get; set; } = null!;
    }
}
