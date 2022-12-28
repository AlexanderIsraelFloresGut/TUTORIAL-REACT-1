using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class LpcBitacora1
    {
        public int Bitacora { get; set; }
        public string? UsuarioCreacion { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public int? NumLista { get; set; }
        public string? Proveedor { get; set; }
        public string? Notas { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
    }
}
