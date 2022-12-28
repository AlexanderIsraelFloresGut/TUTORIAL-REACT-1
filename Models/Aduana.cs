using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class Aduana
    {
        public Aduana()
        {
            DocumentosCps = new HashSet<DocumentosCp>();
            Pedimentos = new HashSet<Pedimento>();
        }

        public string Aduana1 { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual ICollection<DocumentosCp> DocumentosCps { get; set; }
        public virtual ICollection<Pedimento> Pedimentos { get; set; }
    }
}
