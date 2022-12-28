using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class Plaza2
    {
        public Plaza2()
        {
            Empleado2s = new HashSet<Empleado2>();
            EmpleadoAccPer2s = new HashSet<EmpleadoAccPer2>();
        }

        public string Puesto { get; set; } = null!;
        public string Plaza { get; set; } = null!;
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

        public virtual Departamento2 DepartamentoNavigation { get; set; } = null!;
        public virtual Puesto2 PuestoNavigation { get; set; } = null!;
        public virtual Usuario2 UsuarioNavigation { get; set; } = null!;
        public virtual ICollection<Empleado2> Empleado2s { get; set; }
        public virtual ICollection<EmpleadoAccPer2> EmpleadoAccPer2s { get; set; }
    }
}
