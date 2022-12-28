using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class PresupuestoBi1
    {
        public PresupuestoBi1()
        {
            PresupuestoVersionBi1s = new HashSet<PresupuestoVersionBi1>();
        }

        public string Presupuesto { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public string Moneda { get; set; } = null!;
        public string TipoContabilidad { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual ICollection<PresupuestoVersionBi1> PresupuestoVersionBi1s { get; set; }
    }
}
