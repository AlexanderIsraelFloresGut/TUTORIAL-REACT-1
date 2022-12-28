using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class TipoAccidente1
    {
        public TipoAccidente1()
        {
            EmpleadoAccidente1s = new HashSet<EmpleadoAccidente1>();
        }

        public string TipoAccidente { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual ICollection<EmpleadoAccidente1> EmpleadoAccidente1s { get; set; }
    }
}
