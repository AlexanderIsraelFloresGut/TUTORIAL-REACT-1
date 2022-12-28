using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class Participante1
    {
        public string Participante { get; set; } = null!;
        public string Conjunto { get; set; } = null!;
        public string Nit { get; set; } = null!;
        public decimal PorcParticipacion { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual Conjunto ConjuntoNavigation { get; set; } = null!;
        public virtual Nit1 NitNavigation { get; set; } = null!;
    }
}
