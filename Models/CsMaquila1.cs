using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class CsMaquila1
    {
        public long OrdenProduccion { get; set; }
        public string Articulo { get; set; } = null!;
        public decimal Cantidad { get; set; }
        public decimal Precio { get; set; }
        public decimal PrecioDolar { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
    }
}
