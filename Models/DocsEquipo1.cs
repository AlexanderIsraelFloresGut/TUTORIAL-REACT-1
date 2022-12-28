using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class DocsEquipo1
    {
        public string Equipo { get; set; } = null!;
        public short Numero { get; set; }
        public string Direccion { get; set; } = null!;
        public string? Comentario { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual Equipo1 EquipoNavigation { get; set; } = null!;
    }
}
