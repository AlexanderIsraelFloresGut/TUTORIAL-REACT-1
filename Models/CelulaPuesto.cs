using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class CelulaPuesto
    {
        public string CelulaTrabajo { get; set; } = null!;
        public string Puesto { get; set; } = null!;
        public string TipoMo { get; set; } = null!;
        public short? NumEmpleados { get; set; }
        public decimal? NumHora { get; set; }
        public string? Notas { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual CelulaTrabajo CelulaTrabajoNavigation { get; set; } = null!;
        public virtual Puesto PuestoNavigation { get; set; } = null!;
    }
}
