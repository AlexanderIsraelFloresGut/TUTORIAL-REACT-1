using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class FacturaDocCc1
    {
        public string TipoDocumento { get; set; } = null!;
        public string Factura { get; set; } = null!;
        public short Linea { get; set; }
        public string Tipo { get; set; } = null!;
        public string DocumentoCc { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual DocumentosCc1 DocumentosCc1 { get; set; } = null!;
        public virtual FacturaLinea1 FacturaLinea1 { get; set; } = null!;
    }
}
