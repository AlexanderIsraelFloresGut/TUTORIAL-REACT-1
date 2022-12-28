using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class ProvRetencion1
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
        public DateTime? FechaDesde { get; set; }
        public DateTime? FechaHasta { get; set; }
        public string RetDefault { get; set; } = null!;

        public virtual Retencione1 CodigoRetencionNavigation { get; set; } = null!;
        public virtual Proveedor1 ProveedorNavigation { get; set; } = null!;
    }
}
