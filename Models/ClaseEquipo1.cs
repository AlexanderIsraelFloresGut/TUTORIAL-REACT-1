using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class ClaseEquipo1
    {
        public ClaseEquipo1()
        {
            Equipo1s = new HashSet<Equipo1>();
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

        public virtual ICollection<Equipo1> Equipo1s { get; set; }
    }
}
