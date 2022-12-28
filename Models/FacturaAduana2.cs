using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class FacturaAduana2
    {
        public string Cliente { get; set; } = null!;
        public string TipoDocumento { get; set; } = null!;
        public string Factura { get; set; } = null!;
        public string? NumeroDua { get; set; }
        public DateTime? FechaDua { get; set; }
        public string? NombreAgenAduana { get; set; }
        public string? NitAgenAduana { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual Cliente2 ClienteNavigation { get; set; } = null!;
        public virtual Factura2 Factura2 { get; set; } = null!;
    }
}
