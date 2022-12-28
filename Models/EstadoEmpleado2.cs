using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class EstadoEmpleado2
    {
        public EstadoEmpleado2()
        {
            Empleado2s = new HashSet<Empleado2>();
            EmpleadoAccPer2s = new HashSet<EmpleadoAccPer2>();
            TipoAccion2s = new HashSet<TipoAccion2>();
            TipoSolicitudRh2s = new HashSet<TipoSolicitudRh2>();
        }

        public string EstadoEmpleado { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public string Activo { get; set; } = null!;
        public string Pago { get; set; } = null!;
        public string Temporal { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual ICollection<Empleado2> Empleado2s { get; set; }
        public virtual ICollection<EmpleadoAccPer2> EmpleadoAccPer2s { get; set; }
        public virtual ICollection<TipoAccion2> TipoAccion2s { get; set; }
        public virtual ICollection<TipoSolicitudRh2> TipoSolicitudRh2s { get; set; }
    }
}
