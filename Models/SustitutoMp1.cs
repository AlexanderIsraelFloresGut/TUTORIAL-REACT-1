using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class SustitutoMp1
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

        public virtual Articulo1 MatPrimaOrigNavigation { get; set; } = null!;
        public virtual Articulo1 MatSubstitutoNavigation { get; set; } = null!;
    }
}
