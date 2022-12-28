using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class HistorialDescuento
    {
        public Guid Guid { get; set; }
        public string? Documento { get; set; }
        public string? Caja { get; set; }
        public string? Tipo { get; set; }
        public string Linea { get; set; } = null!;
        public string Regla { get; set; } = null!;
        public string Articulo { get; set; } = null!;
        public decimal Cantidad { get; set; }
        public decimal Descuento { get; set; }
        public string Origen { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
    }
}
