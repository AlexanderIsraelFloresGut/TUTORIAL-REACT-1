using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class NominaConcepto
    {
        public NominaConcepto()
        {
            EmpleadoConcNomis = new HashSet<EmpleadoConcNomi>();
            OpOperDetMos = new HashSet<OpOperDetMo>();
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

        public virtual Concepto ConceptoNavigation { get; set; } = null!;
        public virtual Nomina NominaNavigation { get; set; } = null!;
        public virtual ICollection<EmpleadoConcNomi> EmpleadoConcNomis { get; set; }
        public virtual ICollection<OpOperDetMo> OpOperDetMos { get; set; }
    }
}
