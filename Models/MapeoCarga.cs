using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class MapeoCarga
    {
        public MapeoCarga()
        {
            MapeoDetCargas = new HashSet<MapeoDetCarga>();
        }

        public int Mapeo { get; set; }
        public string Descripcion { get; set; } = null!;
        public string? Ruta { get; set; }
        public string Tabla { get; set; } = null!;
        public string Seleccion { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual ICollection<MapeoDetCarga> MapeoDetCargas { get; set; }
    }
}
