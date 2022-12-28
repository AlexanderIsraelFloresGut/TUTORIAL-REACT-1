using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class DocumentoAnticipo1
    {
        public string TipoDocumento { get; set; } = null!;
        public string Documento { get; set; } = null!;
        public string DocumentoCc { get; set; } = null!;
        public string TipoCc { get; set; } = null!;
        public decimal Monto { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
        public decimal? MontoImpuesto1 { get; set; }
        public decimal? MontoImpuesto2 { get; set; }

        public virtual DocumentosCc1 DocumentosCc1 { get; set; } = null!;
    }
}
