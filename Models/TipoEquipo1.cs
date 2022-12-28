using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class TipoEquipo1
    {
        public TipoEquipo1()
        {
            Equipo1s = new HashSet<Equipo1>();
            TipoEquipoProc1s = new HashSet<TipoEquipoProc1>();
        }

        public string TipoEquipo { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual ICollection<Equipo1> Equipo1s { get; set; }
        public virtual ICollection<TipoEquipoProc1> TipoEquipoProc1s { get; set; }
    }
}
