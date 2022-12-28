using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class AjusteSubsubtipo2
    {
        public string AjusteConfig { get; set; } = null!;
        public string Subsubtipo { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual AjusteConfig2 AjusteConfigNavigation { get; set; } = null!;
    }
}
