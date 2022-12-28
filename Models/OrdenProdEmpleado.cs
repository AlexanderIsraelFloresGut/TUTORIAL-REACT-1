using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class OrdenProdEmpleado
    {
        public long OrdenProduccion { get; set; }
        public string Empleado { get; set; } = null!;
        public string? Rubro { get; set; }
        public decimal? Costo { get; set; }
        public string? Actividad { get; set; }
        public decimal? CostoDolar { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual Empleado EmpleadoNavigation { get; set; } = null!;
    }
}
