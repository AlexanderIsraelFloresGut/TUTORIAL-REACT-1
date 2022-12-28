using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class Menu
    {
        public Menu()
        {
            RolMenus = new HashSet<RolMenu>();
        }

        public int IdMenu { get; set; }
        public string? Url { get; set; }
        public string? Descripcion { get; set; }
        public string? Evento { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual ICollection<RolMenu> RolMenus { get; set; }
    }
}
