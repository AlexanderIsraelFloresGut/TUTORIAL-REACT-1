using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class ClaseEquipo
    {
        public ClaseEquipo()
        {
            Equipos = new HashSet<Equipo>();
        }

        public string Clase { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public string TieneComponen { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual ICollection<Equipo> Equipos { get; set; }
    }
}
