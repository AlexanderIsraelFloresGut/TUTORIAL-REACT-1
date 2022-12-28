using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class TipoAcademico1
    {
        public TipoAcademico1()
        {
            EmpleadoAcademico1s = new HashSet<EmpleadoAcademico1>();
        }

        public string TipoAcademico { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual ICollection<EmpleadoAcademico1> EmpleadoAcademico1s { get; set; }
    }
}
