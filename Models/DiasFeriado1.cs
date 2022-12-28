using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class DiasFeriado1
    {
        public short IdFeriado { get; set; }
        public short Dia { get; set; }
        public short Mes { get; set; }
        public short? Ano { get; set; }
        public string? Descripcion { get; set; }
        public string Tipo { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
    }
}
