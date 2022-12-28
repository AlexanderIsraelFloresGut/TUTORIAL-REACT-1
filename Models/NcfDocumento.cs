using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class NcfDocumento
    {
        public string Ncf { get; set; } = null!;
        public Guid DocRowpointer { get; set; }
        public string Modulo { get; set; } = null!;
        public string TipoDocumento { get; set; } = null!;
        public string Tabla { get; set; } = null!;
        public string? TipoAnulacion { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
        public DateTime? FechaVenceSecuencia { get; set; }
        public int? Secuencia { get; set; }
    }
}
