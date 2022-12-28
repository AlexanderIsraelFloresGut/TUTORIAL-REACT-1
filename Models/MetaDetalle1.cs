using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class MetaDetalle1
    {
        public int Metadetalle { get; set; }
        public int Meta { get; set; }
        public string Codigo1 { get; set; } = null!;
        public string? Codigo2 { get; set; }
        public DateTime Mes { get; set; }
        public decimal Valormeta { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual Metum1 MetaNavigation { get; set; } = null!;
    }
}
