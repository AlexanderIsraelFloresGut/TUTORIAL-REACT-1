using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class EquipoEquivalente
    {
        public string Equipo { get; set; } = null!;
        public string EquipoEquivalente1 { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual Equipo EquipoEquivalente1Navigation { get; set; } = null!;
        public virtual Equipo EquipoNavigation { get; set; } = null!;
    }
}
