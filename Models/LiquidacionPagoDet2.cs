using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class LiquidacionPagoDet2
    {
        public short Liquidacion { get; set; }
        public string? Proveedor { get; set; }
        public string? Documento { get; set; }
        public decimal MontoCalculado { get; set; }
        public decimal MontoGenerado { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
        public string? Cliente { get; set; }
        public string? Empleado { get; set; }
        public int? NumeroCredito { get; set; }

        public virtual Cliente2? ClienteNavigation { get; set; }
        public virtual LiquidacionPago2 LiquidacionNavigation { get; set; } = null!;
        public virtual Proveedor2? ProveedorNavigation { get; set; }
    }
}
