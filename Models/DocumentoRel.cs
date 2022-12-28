using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class DocumentoRel
    {
        public string DocumentoCc { get; set; } = null!;
        public string TipoCc { get; set; } = null!;
        public string DocumentoPago { get; set; } = null!;
        public decimal? MontoDocumentoOrigen { get; set; }
        public DateTime? FechaDocumentoOrigen { get; set; }
        public string? DocumentoFiscal { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual RecepcionPago DocumentoPagoNavigation { get; set; } = null!;
    }
}
