using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class Plaza
    {
        public Plaza()
        {
            EmpleadoAccPers = new HashSet<EmpleadoAccPer>();
            Empleados = new HashSet<Empleado>();
        }

        public string Puesto { get; set; } = null!;
        public string Plaza1 { get; set; } = null!;
        public string Departamento { get; set; } = null!;
        public string Compartida { get; set; } = null!;
        public string Tipo { get; set; } = null!;
        public string Estado { get; set; } = null!;
        public int CantidadEmpleados { get; set; }
        public DateTime? FechaVacante { get; set; }
        public DateTime? RigeDesde { get; set; }
        public DateTime? RigeHasta { get; set; }
        public string? Notas { get; set; }
        public string Usuario { get; set; } = null!;
        public DateTime FechaHoraMod { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual Departamento DepartamentoNavigation { get; set; } = null!;
        public virtual Puesto PuestoNavigation { get; set; } = null!;
        public virtual Usuario2 UsuarioNavigation { get; set; } = null!;
        public virtual ICollection<EmpleadoAccPer> EmpleadoAccPers { get; set; }
        public virtual ICollection<Empleado> Empleados { get; set; }
    }
}
