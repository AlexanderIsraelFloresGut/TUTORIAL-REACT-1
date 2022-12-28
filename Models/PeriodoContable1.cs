using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class PeriodoContable1
    {
        public PeriodoContable1()
        {
            HistCierreCg1s = new HashSet<HistCierreCg1>();
        }

        public DateTime FechaFinal { get; set; }
        public string Descripcion { get; set; } = null!;
        public string Contabilidad { get; set; } = null!;
        public string FinPeriodoAnual { get; set; } = null!;
        public string Estado { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual ICollection<HistCierreCg1> HistCierreCg1s { get; set; }
    }
}
