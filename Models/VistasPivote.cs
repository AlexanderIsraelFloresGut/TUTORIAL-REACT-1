using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class VistasPivote
    {
        public string Cubo { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public string Definicion { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual CuboPrivilegio CuboNavigation { get; set; } = null!;
    }
}
