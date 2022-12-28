using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class TipoEquipo
    {
        public TipoEquipo()
        {
            Equipos = new HashSet<Equipo>();
            TipoEquipoProcs = new HashSet<TipoEquipoProc>();
        }

        public string TipoEquipo1 { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual ICollection<Equipo> Equipos { get; set; }
        public virtual ICollection<TipoEquipoProc> TipoEquipoProcs { get; set; }
    }
}
