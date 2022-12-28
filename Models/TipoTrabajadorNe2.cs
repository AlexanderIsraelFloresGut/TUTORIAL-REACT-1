using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class TipoTrabajadorNe2
    {
        public TipoTrabajadorNe2()
        {
            Empleado2s = new HashSet<Empleado2>();
        }

        public string TipoTrabajadorNe { get; set; } = null!;
        public string? Nombre { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual ICollection<Empleado2> Empleado2s { get; set; }
    }
}
