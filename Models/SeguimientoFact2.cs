using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class SeguimientoFact2
    {
        public int Consecutivo { get; set; }
        public string Factura { get; set; } = null!;
        public string Estado { get; set; } = null!;
        public string? Descripcion { get; set; }
        public string Medio { get; set; } = null!;
        public string Fuente { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
    }
}
