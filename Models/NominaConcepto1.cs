using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class NominaConcepto1
    {
        public NominaConcepto1()
        {
            EmpleadoConcNomi1s = new HashSet<EmpleadoConcNomi1>();
            OpOperDetMo1s = new HashSet<OpOperDetMo1>();
        }

        public string Nomina { get; set; } = null!;
        public string Concepto { get; set; } = null!;
        public string Activo { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual Concepto1 ConceptoNavigation { get; set; } = null!;
        public virtual Nomina1 NominaNavigation { get; set; } = null!;
        public virtual ICollection<EmpleadoConcNomi1> EmpleadoConcNomi1s { get; set; }
        public virtual ICollection<OpOperDetMo1> OpOperDetMo1s { get; set; }
    }
}
