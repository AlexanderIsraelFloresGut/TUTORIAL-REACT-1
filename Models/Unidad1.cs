using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class Unidad1
    {
        public Unidad1()
        {
            CuentaContable1s = new HashSet<CuentaContable1>();
            RubroLiq1s = new HashSet<RubroLiq1>();
        }

        public string Unidad { get; set; } = null!;
        public string? Descripcion { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual ICollection<CuentaContable1> CuentaContable1s { get; set; }
        public virtual ICollection<RubroLiq1> RubroLiq1s { get; set; }
    }
}
