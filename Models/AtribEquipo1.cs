using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class AtribEquipo1
    {
        public string Equipo { get; set; } = null!;
        public string Atributo { get; set; } = null!;
        public decimal Maxima { get; set; }
        public decimal Minima { get; set; }
        public decimal Normal { get; set; }
        public string Unidad { get; set; } = null!;
        public string Valor { get; set; } = null!;
        public string? Notas { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual Atributo1 AtributoNavigation { get; set; } = null!;
        public virtual Equipo1 EquipoNavigation { get; set; } = null!;
    }
}
