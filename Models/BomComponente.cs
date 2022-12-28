using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class BomComponente
    {
        public string Usuario { get; set; } = null!;
        public string Componente { get; set; } = null!;
        public string? Version { get; set; }
        public decimal Cantidad { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
    }
}
