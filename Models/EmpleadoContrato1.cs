using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class EmpleadoContrato1
    {
        public EmpleadoContrato1()
        {
            LiquidacionContra1s = new HashSet<LiquidacionContra1>();
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

        public virtual Empleado1 EmpleadoNavigation { get; set; } = null!;
        public virtual TipoContrato1 TipoContratoNavigation { get; set; } = null!;
        public virtual ICollection<LiquidacionContra1> LiquidacionContra1s { get; set; }
    }
}
