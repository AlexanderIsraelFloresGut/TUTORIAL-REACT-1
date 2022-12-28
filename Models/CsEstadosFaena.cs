using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class CsEstadosFaena
    {
        public CsEstadosFaena()
        {
            CsFaenas = new HashSet<CsFaena>();
        }

        public int Estado { get; set; }
        public string? Descripcion { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual ICollection<CsFaena> CsFaenas { get; set; }
    }
}
