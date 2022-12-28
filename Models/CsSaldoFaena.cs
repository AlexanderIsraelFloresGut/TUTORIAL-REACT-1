using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class CsSaldoFaena
    {
        public string Proveedor { get; set; } = null!;
        public string Faena { get; set; } = null!;
        public decimal? SaldoActual { get; set; }
        public decimal? SaldoAnterior { get; set; }
        public decimal? SaldoAlinsa { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
    }
}
