using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class IntermediaAnexo
    {
        public int Id { get; set; }
        public string? OrdenProduccion { get; set; }
        public string? Factura { get; set; }
        public string? Cliente { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
    }
}
