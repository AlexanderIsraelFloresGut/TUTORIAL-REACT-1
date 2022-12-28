using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class LiquidacionContra1
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

        public virtual EmpleadoContrato1 EmpleadoContrato1 { get; set; } = null!;
        public virtual Liquidacion1 LiquidacionNavigation { get; set; } = null!;
    }
}
