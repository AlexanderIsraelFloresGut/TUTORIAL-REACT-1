using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class LiqPcDesgContum2
    {
        public string Liquidacion { get; set; } = null!;
        public string CentroCosto { get; set; } = null!;
        public string CuentaContable { get; set; } = null!;
        public string? Rubro { get; set; }
        public decimal TotalMovLocal { get; set; }
        public decimal? TotalMovDolar { get; set; }
        public decimal TotalAjustLocal { get; set; }
        public decimal? TotalAjustDolar { get; set; }
        public string? UsuarioUltModif { get; set; }
        public DateTime? FchHoraUltModif { get; set; }
        public string Calculado { get; set; } = null!;
        public string? Comentarios { get; set; }
        public string? Celulas { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual CentroCuentum2 C { get; set; } = null!;
        public virtual LiquidacionPc2 LiquidacionNavigation { get; set; } = null!;
        public virtual Usuario2? UsuarioUltModifNavigation { get; set; }
    }
}
