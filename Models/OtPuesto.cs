using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class OtPuesto
    {
        public int OrdenTrabajo { get; set; }
        public string Puesto { get; set; } = null!;
        public decimal HorasEstimadas { get; set; }
        public decimal HorasAcumuladas { get; set; }
        public decimal CostoEstLocal { get; set; }
        public decimal CostoEstDolar { get; set; }
        public decimal CostoAcuLocal { get; set; }
        public decimal CostoAcuDolar { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual OrdenTrabajo OrdenTrabajoNavigation { get; set; } = null!;
        public virtual Puesto PuestoNavigation { get; set; } = null!;
    }
}
