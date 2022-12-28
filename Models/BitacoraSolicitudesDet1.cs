using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class BitacoraSolicitudesDet1
    {
        public int Bitacora { get; set; }
        public int Linea { get; set; }
        public string Articulo { get; set; } = null!;
        public decimal Libras { get; set; }
        public decimal Precio { get; set; }
        public decimal? Merma { get; set; }
        public decimal? Base { get; set; }
        public decimal? MermaMonto { get; set; }
        public decimal? Ret2 { get; set; }
        public decimal? Ret1 { get; set; }
        public decimal? Reintegro { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
    }
}
