using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class RolMenu
    {
        public int IdRolMenu { get; set; }
        public int? IdRol { get; set; }
        public int? IdMenu { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual Menu? IdMenuNavigation { get; set; }
        public virtual RolUsuarioWeb? IdRolNavigation { get; set; }
    }
}
