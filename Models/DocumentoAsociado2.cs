using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class DocumentoAsociado2
    {
        public string Tipo { get; set; } = null!;
        public string TipoDocOrigen { get; set; } = null!;
        public string Documento { get; set; } = null!;
        public string DocOrigen { get; set; } = null!;
        public string Clase { get; set; } = null!;
        public string Aprobado { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual DocumentosCc2 DocumentosCc2 { get; set; } = null!;
        public virtual DocumentosCc2 DocumentosCc2Navigation { get; set; } = null!;
    }
}
