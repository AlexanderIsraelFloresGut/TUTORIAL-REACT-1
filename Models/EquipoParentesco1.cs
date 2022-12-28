using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class EquipoParentesco1
    {
        public string EquipoPadre { get; set; } = null!;
        public string EquipoHijo { get; set; } = null!;
        public string? Comentario { get; set; }
        public string? Usuario { get; set; }
        public DateTime FechaHora { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual Equipo1 EquipoHijoNavigation { get; set; } = null!;
        public virtual Equipo1 EquipoPadreNavigation { get; set; } = null!;
        public virtual Usuario2? UsuarioNavigation { get; set; }
    }
}
