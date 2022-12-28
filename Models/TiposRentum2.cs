using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class TiposRentum2
    {
        public TiposRentum2()
        {
            Devolucion2s = new HashSet<Devolucion2>();
            DocumentoEmbarque2s = new HashSet<DocumentoEmbarque2>();
            DocumentosCp2s = new HashSet<DocumentosCp2>();
        }

        public string TipoRenta { get; set; } = null!;
        public string? Descripcion { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual ICollection<Devolucion2> Devolucion2s { get; set; }
        public virtual ICollection<DocumentoEmbarque2> DocumentoEmbarque2s { get; set; }
        public virtual ICollection<DocumentosCp2> DocumentosCp2s { get; set; }
    }
}
