using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class ExoneracionOperacione
    {
        public ExoneracionOperacione()
        {
            Proveedors = new HashSet<Proveedor>();
        }

        public string ExoneracionOper { get; set; } = null!;
        public string? Descripcion { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual ICollection<Proveedor> Proveedors { get; set; }
    }
}
