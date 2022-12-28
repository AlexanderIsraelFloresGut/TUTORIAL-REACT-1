using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class AsocHerram1
    {
        public string Herramienta { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public string TipoHerram { get; set; } = null!;
        public string? Empleado { get; set; }
        public DateTime? FechaPrestamo { get; set; }
        public DateTime FechaIngreso { get; set; }
        public decimal Costo { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual Empleado1? EmpleadoNavigation { get; set; }
        public virtual TipoHerram1 TipoHerramNavigation { get; set; } = null!;
    }
}
