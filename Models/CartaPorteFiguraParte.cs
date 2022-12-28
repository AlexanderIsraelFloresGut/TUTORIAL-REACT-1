using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class CartaPorteFiguraParte
    {
        public string FiguraParte { get; set; } = null!;
        public string Parte { get; set; } = null!;
        public string Figura { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual CartaPorteOperador FiguraNavigation { get; set; } = null!;
        public virtual CartaPorteParteTransporte ParteNavigation { get; set; } = null!;
    }
}
