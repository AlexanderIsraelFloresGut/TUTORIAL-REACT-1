using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class ClasifBienesServAdq1
    {
        public ClasifBienesServAdq1()
        {
            Devolucion1s = new HashSet<Devolucion1>();
            DocumentoEmbarque1s = new HashSet<DocumentoEmbarque1>();
            DocumentosCp1s = new HashSet<DocumentosCp1>();
        }

        public string Clasificacion { get; set; } = null!;
        public string? Descripcion { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual ICollection<Devolucion1> Devolucion1s { get; set; }
        public virtual ICollection<DocumentoEmbarque1> DocumentoEmbarque1s { get; set; }
        public virtual ICollection<DocumentosCp1> DocumentosCp1s { get; set; }
    }
}
