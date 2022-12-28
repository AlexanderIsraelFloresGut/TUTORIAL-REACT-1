using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class LpcListaPrecioCompraDetalle
    {
        public int NumLista { get; set; }
        public string Articulo { get; set; } = null!;
        public decimal PrecioLocal { get; set; }
        public decimal? PrecioDolar { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual LpcListasPrecioCompra NumListaNavigation { get; set; } = null!;
    }
}
