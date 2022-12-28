using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class DefinicionPivoteBi
    {
        public int Definicion { get; set; }
        public string Nombre { get; set; } = null!;
        public string Tipo { get; set; } = null!;
        public string? Vista { get; set; }
        public string? Cubo { get; set; }
        public string? Detalle { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual CuboPrivilegio? CuboNavigation { get; set; }
        public virtual VistaBi? VistaNavigation { get; set; }
    }
}
