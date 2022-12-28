using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class AsientoRecuLinea2
    {
        public string AsientoRecurrente { get; set; } = null!;
        public short AsientoRecuLinea { get; set; }
        public string? Nit { get; set; }
        public string CentroCosto { get; set; } = null!;
        public string CuentaContable { get; set; } = null!;
        public decimal? Debito { get; set; }
        public decimal? Credito { get; set; }
        public string UsaTcambioExt { get; set; } = null!;
        public string Referencia { get; set; } = null!;
        public string? Proyecto { get; set; }
        public string? Fase { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual AsientoRecurrente2 AsientoRecurrenteNavigation { get; set; } = null!;
        public virtual CentroCuentum2 C { get; set; } = null!;
        public virtual Nit2? NitNavigation { get; set; }
    }
}
