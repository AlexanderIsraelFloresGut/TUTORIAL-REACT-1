using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class CsLiquidacionDetFaena
    {
        public int Liquidacion { get; set; }
        public string Documento { get; set; } = null!;
        public string? Clasificacion { get; set; }
        public decimal? MontoLocal { get; set; }
        public decimal? MontoDolar { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
    }
}
