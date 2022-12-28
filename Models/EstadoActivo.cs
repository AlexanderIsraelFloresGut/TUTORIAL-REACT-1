using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class EstadoActivo
    {
        public EstadoActivo()
        {
            ActivoAccionEstadoActivoAntNavigations = new HashSet<ActivoAccion>();
            ActivoAccionEstadoActivoNavigations = new HashSet<ActivoAccion>();
            ActivoFijos = new HashSet<ActivoFijo>();
        }

        public string EstadoActivo1 { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public string? Activo { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual ICollection<ActivoAccion> ActivoAccionEstadoActivoAntNavigations { get; set; }
        public virtual ICollection<ActivoAccion> ActivoAccionEstadoActivoNavigations { get; set; }
        public virtual ICollection<ActivoFijo> ActivoFijos { get; set; }
    }
}
