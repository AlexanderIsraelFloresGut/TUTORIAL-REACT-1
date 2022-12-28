using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class PeriodoNomina1
    {
        public PeriodoNomina1()
        {
            Nomina1s = new HashSet<Nomina1>();
        }

        public string PeriodoNomina { get; set; } = null!;
        public string? Nombre { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual ICollection<Nomina1> Nomina1s { get; set; }
    }
}
