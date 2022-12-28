using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class LpcBitacoraDetalle1
    {
        public int Bitacora { get; set; }
        public int Linea { get; set; }
        public string? Proveedor { get; set; }
        public string? Articulo { get; set; }
        public decimal? PrecioOld { get; set; }
        public decimal? PrecioNew { get; set; }
        public string? Nota { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
    }
}
