using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class LpcListasPrecioCompra
    {
        public int NumLista { get; set; }
        public string Descripcion { get; set; } = null!;
        public string? Notas { get; set; }
        public string? UsuarioUltMod { get; set; }
        public DateTime? FechaUltMod { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
    }
}
