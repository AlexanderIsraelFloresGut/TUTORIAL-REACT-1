using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class CgAux1
    {
        public string GuidOrigen { get; set; } = null!;
        public string TablaOrigen { get; set; } = null!;
        public string Asiento { get; set; } = null!;
        public int Linea { get; set; }
        public string? Comentario { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
    }
}
