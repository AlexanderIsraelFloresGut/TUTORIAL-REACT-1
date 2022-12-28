using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class Ubicacion
    {
        public Ubicacion()
        {
            ActivoAccions = new HashSet<ActivoAccion>();
            ActivoFijos = new HashSet<ActivoFijo>();
            CalculoVacacionals = new HashSet<CalculoVacacional>();
            Empleados = new HashSet<Empleado>();
            HistoricoEmpleados = new HashSet<HistoricoEmpleado>();
        }

        public string Ubicacion1 { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual ICollection<ActivoAccion> ActivoAccions { get; set; }
        public virtual ICollection<ActivoFijo> ActivoFijos { get; set; }
        public virtual ICollection<CalculoVacacional> CalculoVacacionals { get; set; }
        public virtual ICollection<Empleado> Empleados { get; set; }
        public virtual ICollection<HistoricoEmpleado> HistoricoEmpleados { get; set; }
    }
}
