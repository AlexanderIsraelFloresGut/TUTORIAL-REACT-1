using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class GuidRelacionado
    {
        public string GuidOrigen { get; set; } = null!;
        public string GuidRelacionado1 { get; set; } = null!;
        public string TablaOrigen { get; set; } = null!;
        public string TablaRelacionada { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
    }
}
