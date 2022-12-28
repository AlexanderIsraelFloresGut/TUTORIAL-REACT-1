using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class EstadoActivo2
    {
        public EstadoActivo2()
        {
            ActivoAccion2EstadoActivoAntNavigations = new HashSet<ActivoAccion2>();
            ActivoAccion2EstadoActivoNavigations = new HashSet<ActivoAccion2>();
            ActivoFijo2s = new HashSet<ActivoFijo2>();
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

        public virtual ICollection<ActivoAccion2> ActivoAccion2EstadoActivoAntNavigations { get; set; }
        public virtual ICollection<ActivoAccion2> ActivoAccion2EstadoActivoNavigations { get; set; }
        public virtual ICollection<ActivoFijo2> ActivoFijo2s { get; set; }
    }
}
