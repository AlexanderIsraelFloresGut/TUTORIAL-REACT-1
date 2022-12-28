using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class Ubicacion1
    {
        public Ubicacion1()
        {
            ActivoAccion1s = new HashSet<ActivoAccion1>();
            ActivoFijo1s = new HashSet<ActivoFijo1>();
            CalculoVacacional1s = new HashSet<CalculoVacacional1>();
            Empleado1s = new HashSet<Empleado1>();
            HistoricoEmpleado1s = new HashSet<HistoricoEmpleado1>();
        }

        public string Ubicacion { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual ICollection<ActivoAccion1> ActivoAccion1s { get; set; }
        public virtual ICollection<ActivoFijo1> ActivoFijo1s { get; set; }
        public virtual ICollection<CalculoVacacional1> CalculoVacacional1s { get; set; }
        public virtual ICollection<Empleado1> Empleado1s { get; set; }
        public virtual ICollection<HistoricoEmpleado1> HistoricoEmpleado1s { get; set; }
    }
}
