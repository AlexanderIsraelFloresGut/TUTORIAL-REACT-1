using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class Aduana2
    {
        public Aduana2()
        {
            DocumentosCp2s = new HashSet<DocumentosCp2>();
            Pedimento2s = new HashSet<Pedimento2>();
        }

        public string Aduana { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual ICollection<DocumentosCp2> DocumentosCp2s { get; set; }
        public virtual ICollection<Pedimento2> Pedimento2s { get; set; }
    }
}
