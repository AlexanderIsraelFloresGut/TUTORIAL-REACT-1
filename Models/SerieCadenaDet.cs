using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class SerieCadenaDet
    {
        public int SerieCadena { get; set; }
        public string SerieInicial { get; set; } = null!;
        public string SerieFinal { get; set; } = null!;
        public decimal Cantidad { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual SerieCadena SerieCadenaNavigation { get; set; } = null!;
    }
}
