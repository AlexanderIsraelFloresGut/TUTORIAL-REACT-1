using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class Marca1
    {
        public Marca1()
        {
            Equipo1s = new HashSet<Equipo1>();
        }

        public string Marca { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual ICollection<Equipo1> Equipo1s { get; set; }
    }
}
