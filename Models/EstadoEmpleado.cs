using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class EstadoEmpleado
    {
        public EstadoEmpleado()
        {
            EmpleadoAccPers = new HashSet<EmpleadoAccPer>();
            Empleados = new HashSet<Empleado>();
            TipoAccions = new HashSet<TipoAccion>();
            TipoSolicitudRhs = new HashSet<TipoSolicitudRh>();
        }

        public string EstadoEmpleado1 { get; set; } = null!;
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

        public virtual ICollection<EmpleadoAccPer> EmpleadoAccPers { get; set; }
        public virtual ICollection<Empleado> Empleados { get; set; }
        public virtual ICollection<TipoAccion> TipoAccions { get; set; }
        public virtual ICollection<TipoSolicitudRh> TipoSolicitudRhs { get; set; }
    }
}
