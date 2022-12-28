using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class ProvRetencion2
    {
        public string Proveedor { get; set; } = null!;
        public string CodigoRetencion { get; set; } = null!;
        public string? Notas { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual Retencione2 CodigoRetencionNavigation { get; set; } = null!;
        public virtual Proveedor2 ProveedorNavigation { get; set; } = null!;
    }
}
