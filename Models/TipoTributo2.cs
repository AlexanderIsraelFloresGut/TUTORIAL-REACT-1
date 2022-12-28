using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class TipoTributo2
    {
        public string Codigo { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public string CodInternacional { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public string? UnEce { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
    }
}
