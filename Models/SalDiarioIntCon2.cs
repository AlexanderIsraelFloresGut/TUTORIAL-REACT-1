using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class SalDiarioIntCon2
    {
        public int Consecutivo { get; set; }
        public string Concepto { get; set; } = null!;
        public string Modalidad { get; set; } = null!;
        public decimal? TopeExencion { get; set; }
        public string? SumaSdi { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual Concepto2 ConceptoNavigation { get; set; } = null!;
        public virtual SalDiarioInt2 ConsecutivoNavigation { get; set; } = null!;
    }
}
