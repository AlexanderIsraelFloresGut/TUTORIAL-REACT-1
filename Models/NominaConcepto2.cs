using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class NominaConcepto2
    {
        public NominaConcepto2()
        {
            EmpleadoConcNomi2s = new HashSet<EmpleadoConcNomi2>();
            OpOperDetMo2s = new HashSet<OpOperDetMo2>();
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

        public virtual Concepto2 ConceptoNavigation { get; set; } = null!;
        public virtual Nomina2 NominaNavigation { get; set; } = null!;
        public virtual ICollection<EmpleadoConcNomi2> EmpleadoConcNomi2s { get; set; }
        public virtual ICollection<OpOperDetMo2> OpOperDetMo2s { get; set; }
    }
}
