using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class PaqueteDescuento
    {
        public PaqueteDescuento()
        {
            PaqDescGrupos = new HashSet<PaqDescGrupo>();
            PaqDescRegDescs = new HashSet<PaqDescRegDesc>();
        }

        public string PaqueteDescuento1 { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public string Activo { get; set; } = null!;
        public string TodaTienda { get; set; } = null!;
        public DateTime FechaRige { get; set; }
        public DateTime FechaVence { get; set; }
        public string? Notas { get; set; }
        public DateTime? FechaHoraInicio { get; set; }
        public DateTime? FechaHoraFin { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual ICollection<PaqDescGrupo> PaqDescGrupos { get; set; }
        public virtual ICollection<PaqDescRegDesc> PaqDescRegDescs { get; set; }
    }
}
