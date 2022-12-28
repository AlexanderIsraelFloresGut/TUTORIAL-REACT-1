using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class Permiso
    {
        public int Id { get; set; }
        public string? Descripcion { get; set; }
        public string? Modulo { get; set; }
        public int? RolId { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual Rol? Rol { get; set; }
    }
}
