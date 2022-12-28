using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class Unidad
    {
        public Unidad()
        {
            CuentaContables = new HashSet<CuentaContable>();
            RubroLiqs = new HashSet<RubroLiq>();
        }

        public string Unidad1 { get; set; } = null!;
        public string? Descripcion { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual ICollection<CuentaContable> CuentaContables { get; set; }
        public virtual ICollection<RubroLiq> RubroLiqs { get; set; }
    }
}
