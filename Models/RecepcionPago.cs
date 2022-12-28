using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class RecepcionPago
    {
        public RecepcionPago()
        {
            DocumentoRels = new HashSet<DocumentoRel>();
        }

        public string Cliente { get; set; } = null!;
        public string CodigoConsecutivo { get; set; } = null!;
        public string NumeroConsecutivo { get; set; } = null!;
        public string? DocumentoFiscal { get; set; }
        public DateTime Fecha { get; set; }
        public string? TipoRelacion { get; set; }
        public string? EstadoCancelacion { get; set; }
        public string? MotivoCancelacion { get; set; }
        public string? FolioFiscalSustituto { get; set; }
        public string? FolioFiscalRelacionado { get; set; }
        public string? Anulada { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual ICollection<DocumentoRel> DocumentoRels { get; set; }
    }
}
