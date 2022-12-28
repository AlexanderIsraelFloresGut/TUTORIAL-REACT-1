using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class DocumentosRh
    {
        public string Documento { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public string? Ubicacion { get; set; }
        public string? Notas { get; set; }
        public int? Identificador { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual Documento? IdentificadorNavigation { get; set; }
    }
}
