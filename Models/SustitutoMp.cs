using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class SustitutoMp
    {
        public string MatPrimaOrig { get; set; } = null!;
        public string MatSubstituto { get; set; } = null!;
        public DateTime PeriodoInicio { get; set; }
        public DateTime PeriodoFin { get; set; }
        public decimal Equivalencia { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual Articulo MatPrimaOrigNavigation { get; set; } = null!;
        public virtual Articulo MatSubstitutoNavigation { get; set; } = null!;
    }
}
