using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class EstrucProcesoCosteo
    {
        public string LlaveProceso { get; set; } = null!;
        public string Articulo { get; set; } = null!;
        public string Version { get; set; } = null!;
        public int Nivel { get; set; }
        public string Seleccionado { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
    }
}
