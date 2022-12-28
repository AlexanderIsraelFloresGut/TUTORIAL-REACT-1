using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class ArchivoAplicado
    {
        public string Compania { get; set; } = null!;
        public string Archivo { get; set; } = null!;
        public string Estado { get; set; } = null!;
        public string AplicadoPor { get; set; } = null!;
        public DateTime? FechaHoraAplic { get; set; }
        public string? Contenido { get; set; }
        public string? Tipo { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
    }
}
