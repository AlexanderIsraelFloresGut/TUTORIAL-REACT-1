using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class Ubicacion2
    {
        public Ubicacion2()
        {
            ActivoAccion2s = new HashSet<ActivoAccion2>();
            ActivoFijo2s = new HashSet<ActivoFijo2>();
            CalculoVacacional2s = new HashSet<CalculoVacacional2>();
            Empleado2s = new HashSet<Empleado2>();
            HistoricoEmpleado2s = new HashSet<HistoricoEmpleado2>();
        }

        public string Ubicacion { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual ICollection<ActivoAccion2> ActivoAccion2s { get; set; }
        public virtual ICollection<ActivoFijo2> ActivoFijo2s { get; set; }
        public virtual ICollection<CalculoVacacional2> CalculoVacacional2s { get; set; }
        public virtual ICollection<Empleado2> Empleado2s { get; set; }
        public virtual ICollection<HistoricoEmpleado2> HistoricoEmpleado2s { get; set; }
    }
}
