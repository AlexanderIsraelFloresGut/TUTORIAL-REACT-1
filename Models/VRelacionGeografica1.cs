using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class VRelacionGeografica1
    {
        public string Pais { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public string? DivisionGeografica1 { get; set; }
        public string? NombreDivisionGeografica1 { get; set; }
        public string? DivisionGeografica2 { get; set; }
        public string? NombreDivisionGeografica2 { get; set; }
        public string? DivisionGeografica3 { get; set; }
        public string? NombreDivisionGeografica3 { get; set; }
        public string? DivisionGeografica4 { get; set; }
        public string? NombreDivisionGeografica4 { get; set; }
        public Guid Rowpointer { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
    }
}
