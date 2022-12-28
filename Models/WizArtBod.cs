using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class WizArtBod
    {
        public short Secuencia { get; set; }
        public string Articulo { get; set; } = null!;
        public decimal Cantidad { get; set; }
        public string? Cliente { get; set; }
        public string? Estructura { get; set; }
        public string? Version { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaRequerida { get; set; }
        public string? BodegaMp { get; set; }
        public string? BodegaPt { get; set; }
        public string? Notas { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
    }
}
