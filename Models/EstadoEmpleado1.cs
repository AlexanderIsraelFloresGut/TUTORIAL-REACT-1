using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class EstadoEmpleado1
    {
        public EstadoEmpleado1()
        {
            Empleado1s = new HashSet<Empleado1>();
            EmpleadoAccPer1s = new HashSet<EmpleadoAccPer1>();
            TipoAccion1s = new HashSet<TipoAccion1>();
            TipoSolicitudRh1s = new HashSet<TipoSolicitudRh1>();
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

        public virtual ICollection<Empleado1> Empleado1s { get; set; }
        public virtual ICollection<EmpleadoAccPer1> EmpleadoAccPer1s { get; set; }
        public virtual ICollection<TipoAccion1> TipoAccion1s { get; set; }
        public virtual ICollection<TipoSolicitudRh1> TipoSolicitudRh1s { get; set; }
    }
}
