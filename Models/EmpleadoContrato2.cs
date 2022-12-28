using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class EmpleadoContrato2
    {
        public EmpleadoContrato2()
        {
            LiquidacionContra2s = new HashSet<LiquidacionContra2>();
        }

        public string Empleado { get; set; } = null!;
        public DateTime FechaInicio { get; set; }
        public string TipoContrato { get; set; } = null!;
        public DateTime FechaFinalizacion { get; set; }
        public string EstadoContrato { get; set; } = null!;
        public string? Notas { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual Empleado2 EmpleadoNavigation { get; set; } = null!;
        public virtual TipoContrato2 TipoContratoNavigation { get; set; } = null!;
        public virtual ICollection<LiquidacionContra2> LiquidacionContra2s { get; set; }
    }
}
