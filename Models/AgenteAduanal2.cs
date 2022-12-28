using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class AgenteAduanal2
    {
        public AgenteAduanal2()
        {
            Pedimento2s = new HashSet<Pedimento2>();
        }

        public string AgenteAduanal { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual ICollection<Pedimento2> Pedimento2s { get; set; }
    }
}
