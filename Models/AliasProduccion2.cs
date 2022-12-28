using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class AliasProduccion2
    {
        public AliasProduccion2()
        {
            ArticuloEspe2s = new HashSet<ArticuloEspe2>();
        }

        public string AliasProduccion { get; set; } = null!;
        public string Articulo { get; set; } = null!;
        public string? Descripcion { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual Articulo2 ArticuloNavigation { get; set; } = null!;
        public virtual ICollection<ArticuloEspe2> ArticuloEspe2s { get; set; }
    }
}
