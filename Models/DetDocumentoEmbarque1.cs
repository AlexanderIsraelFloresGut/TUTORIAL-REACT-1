using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class DetDocumentoEmbarque1
    {
        public DetDocumentoEmbarque1()
        {
            EmbarqueLinea1s = new HashSet<EmbarqueLinea1>();
        }

        public string Documento { get; set; } = null!;
        public string Proveedor { get; set; } = null!;
        public string TipoDocumento { get; set; } = null!;
        public string Embarque { get; set; } = null!;
        public decimal MontoAplicar { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual DocumentoEmbarque1 DocumentoEmbarque1 { get; set; } = null!;
        public virtual Embarque1 EmbarqueNavigation { get; set; } = null!;
        public virtual ICollection<EmbarqueLinea1> EmbarqueLinea1s { get; set; }
    }
}
