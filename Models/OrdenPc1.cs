using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class OrdenPc1
    {
        public string OrdenProduccion { get; set; } = null!;
        public int Noitem { get; set; }
        public string? Padre { get; set; }
        public string Componente { get; set; } = null!;
        public int? Nivel { get; set; }
        public string? Lista { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
    }
}
