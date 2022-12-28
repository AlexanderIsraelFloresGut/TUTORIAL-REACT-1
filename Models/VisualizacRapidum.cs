using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class VisualizacRapidum
    {
        public string Tabla { get; set; } = null!;
        public string Campo { get; set; } = null!;
        public string Texto { get; set; } = null!;
        public string Cultura { get; set; } = null!;
        public short? Secuencia { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
    }
}
