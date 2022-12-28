using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class CsLiquidacionFaena
    {
        public int Liquidacion { get; set; }
        public string? Faena { get; set; }
        public decimal? TotalAlisto { get; set; }
        public decimal? TotalEntrega { get; set; }
        public decimal? Aprovechamiento { get; set; }
        public DateTime? FechaLiquidacion { get; set; }
        public string? UsuarioLiquido { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
    }
}
