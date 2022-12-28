using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class DetDocumentoEmbarque
    {
        public DetDocumentoEmbarque()
        {
            EmbarqueLineas = new HashSet<EmbarqueLinea>();
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

        public virtual DocumentoEmbarque DocumentoEmbarque { get; set; } = null!;
        public virtual Embarque EmbarqueNavigation { get; set; } = null!;
        public virtual ICollection<EmbarqueLinea> EmbarqueLineas { get; set; }
    }
}
