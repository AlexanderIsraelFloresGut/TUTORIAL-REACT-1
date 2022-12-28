using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class Usuario
    {
        public int Id { get; set; }
        public string? UserName { get; set; }
        public string? Nombre { get; set; }
        public string? Clave { get; set; }
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
