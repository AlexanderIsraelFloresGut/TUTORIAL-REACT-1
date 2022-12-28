using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class HistoricoDiferido
    {
        public int HistDiferido { get; set; }
        public string Diferido { get; set; } = null!;
        public DateTime Fecha { get; set; }
        public string? Asiento { get; set; }
        public string Usuario { get; set; } = null!;
        public decimal AmortizacionLocal { get; set; }
        public decimal AmortizacionDolar { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
    }
}
