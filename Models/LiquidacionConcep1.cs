using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class LiquidacionConcep1
    {
        public int Liquidacion { get; set; }
        public short Linea { get; set; }
        public string Concepto { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public string TipoConcepto { get; set; } = null!;
        public short Secuencia { get; set; }
        public decimal Cantidad { get; set; }
        public decimal Monto { get; set; }
        public decimal TotalCalculado { get; set; }
        public string? CentroCosto { get; set; }
        public string? CuentaContable { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual CentroCuentum1? C { get; set; }
        public virtual Liquidacion1 LiquidacionNavigation { get; set; } = null!;
    }
}
