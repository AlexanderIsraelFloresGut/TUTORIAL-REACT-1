using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class ModalidadServicio
    {
        public ModalidadServicio()
        {
            Devolucions = new HashSet<Devolucion>();
            DocumentoEmbarques = new HashSet<DocumentoEmbarque>();
            DocumentosCps = new HashSet<DocumentosCp>();
        }

        public string ModalidadServicio1 { get; set; } = null!;
        public string? Descripcion { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual ICollection<Devolucion> Devolucions { get; set; }
        public virtual ICollection<DocumentoEmbarque> DocumentoEmbarques { get; set; }
        public virtual ICollection<DocumentosCp> DocumentosCps { get; set; }
    }
}
