using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class EquipoEquivalente1
    {
        public string Equipo { get; set; } = null!;
        public string EquipoEquivalente { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual Equipo1 EquipoEquivalenteNavigation { get; set; } = null!;
        public virtual Equipo1 EquipoNavigation { get; set; } = null!;
    }
}
