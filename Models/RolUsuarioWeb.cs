using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class RolUsuarioWeb
    {
        public RolUsuarioWeb()
        {
            RolMenus = new HashSet<RolMenu>();
        }

        public int Id { get; set; }
        public string? Rol { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual ICollection<RolMenu> RolMenus { get; set; }
    }
}
