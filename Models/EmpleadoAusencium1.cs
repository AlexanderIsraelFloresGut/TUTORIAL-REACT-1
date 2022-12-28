using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class EmpleadoAusencium1
    {
        public string Empleado { get; set; } = null!;
        public DateTime FechaInicial { get; set; }
        public int? NumeroAccion { get; set; }
        public string TipoAusencia { get; set; } = null!;
        public DateTime? FechaFinal { get; set; }
        public string? Notas { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual Empleado1 EmpleadoNavigation { get; set; } = null!;
        public virtual EmpleadoAccPer1? NumeroAccionNavigation { get; set; }
        public virtual TipoAusencium1 TipoAusenciaNavigation { get; set; } = null!;
    }
}
