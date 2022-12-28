using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class LiquidacionContra
    {
        public int Liquidacion { get; set; }
        public string Empleado { get; set; } = null!;
        public DateTime FechaInicial { get; set; }
        public DateTime FechaFinalAnt { get; set; }
        public DateTime FechaFinalNuev { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual EmpleadoContrato EmpleadoContrato { get; set; } = null!;
        public virtual Liquidacion LiquidacionNavigation { get; set; } = null!;
    }
}
