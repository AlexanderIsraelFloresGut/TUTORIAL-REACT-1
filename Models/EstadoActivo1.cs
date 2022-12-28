using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class EstadoActivo1
    {
        public EstadoActivo1()
        {
            ActivoAccion1EstadoActivoAntNavigations = new HashSet<ActivoAccion1>();
            ActivoAccion1EstadoActivoNavigations = new HashSet<ActivoAccion1>();
            ActivoFijo1s = new HashSet<ActivoFijo1>();
        }

        public string EstadoActivo { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public string? Activo { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual ICollection<ActivoAccion1> ActivoAccion1EstadoActivoAntNavigations { get; set; }
        public virtual ICollection<ActivoAccion1> ActivoAccion1EstadoActivoNavigations { get; set; }
        public virtual ICollection<ActivoFijo1> ActivoFijo1s { get; set; }
    }
}
