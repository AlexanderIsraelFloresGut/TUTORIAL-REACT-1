using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class MapeoDetCarga
    {
        public int Mapeo { get; set; }
        public string Tabla { get; set; } = null!;
        public string ColCargad { get; set; } = null!;
        public string ColArchivo { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual MapeoCarga MapeoNavigation { get; set; } = null!;
    }
}
