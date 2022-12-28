using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class Plaza1
    {
        public Plaza1()
        {
            Empleado1s = new HashSet<Empleado1>();
            EmpleadoAccPer1s = new HashSet<EmpleadoAccPer1>();
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

        public virtual Departamento1 DepartamentoNavigation { get; set; } = null!;
        public virtual Puesto1 PuestoNavigation { get; set; } = null!;
        public virtual Usuario2 UsuarioNavigation { get; set; } = null!;
        public virtual ICollection<Empleado1> Empleado1s { get; set; }
        public virtual ICollection<EmpleadoAccPer1> EmpleadoAccPer1s { get; set; }
    }
}
