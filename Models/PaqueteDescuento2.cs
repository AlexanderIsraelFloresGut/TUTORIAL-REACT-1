using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class PaqueteDescuento2
    {
        public PaqueteDescuento2()
        {
            PaqDescGrupo2s = new HashSet<PaqDescGrupo2>();
            PaqDescRegDesc2s = new HashSet<PaqDescRegDesc2>();
        }

        public string PaqueteDescuento { get; set; } = null!;
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

        public virtual ICollection<PaqDescGrupo2> PaqDescGrupo2s { get; set; }
        public virtual ICollection<PaqDescRegDesc2> PaqDescRegDesc2s { get; set; }
    }
}
