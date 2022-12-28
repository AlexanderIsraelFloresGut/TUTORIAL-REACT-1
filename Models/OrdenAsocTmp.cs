using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class OrdenAsocTmp
    {
        public int Padre { get; set; }
        public int Hija { get; set; }
        public string ArtPadre { get; set; } = null!;
        public string ArtHijo { get; set; } = null!;
        public decimal Cantidad { get; set; }
        public string Relacion { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
    }
}
