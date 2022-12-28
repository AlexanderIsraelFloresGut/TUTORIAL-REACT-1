using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class ArchivosRespuestaNe
    {
        public int Consecutivo { get; set; }
        public string NombreArchivo { get; set; } = null!;
        public DateTime FechaHora { get; set; }
        public string Archivo { get; set; } = null!;
        public string Procesado { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
    }
}
