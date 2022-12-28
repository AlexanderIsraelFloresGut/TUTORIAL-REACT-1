using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class AgenteAduanal1
    {
        public AgenteAduanal1()
        {
            Pedimento1s = new HashSet<Pedimento1>();
        }

        public string AgenteAduanal { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual ICollection<Pedimento1> Pedimento1s { get; set; }
    }
}
