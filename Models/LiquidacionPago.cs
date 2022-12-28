using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class LiquidacionPago
    {
        public short Liquidacion { get; set; }
        public string Moneda { get; set; } = null!;
        public DateTime Periodo { get; set; }
        public string Tipo { get; set; } = null!;
        public short Subtipo { get; set; }
        public string? Notas { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
        public string TipoCc { get; set; } = null!;
        public int SubtipoCc { get; set; }

        public virtual Monedum MonedaNavigation { get; set; } = null!;
        public virtual SubtipoDocCp SubtipoDocCp { get; set; } = null!;
    }
}
