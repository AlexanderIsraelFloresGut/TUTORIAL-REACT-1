using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class CsDocumentosFaena
    {
        public string Documento { get; set; } = null!;
        public string Faena { get; set; } = null!;
        public string? Paquete { get; set; }
        public string? Referencia { get; set; }
        public string? Consecutivo { get; set; }
        public string? Clasificacion { get; set; }
        public int? Auditoria { get; set; }
        public DateTime? FechaVerificacion { get; set; }
        public string? UsuarioVerificacion { get; set; }
        public string? Naturaleza { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
    }
}
