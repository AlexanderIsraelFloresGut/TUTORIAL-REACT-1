using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class BitacoraMensaje
    {
        public string Compania { get; set; } = null!;
        public string Archivo { get; set; } = null!;
        public string Tipo { get; set; } = null!;
        public DateTime FechaHora { get; set; }
        public int? NumMensaje { get; set; }
        public string? TextoMensaje { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
    }
}
