using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class RatiosCuenta1
    {
        public string Codigo { get; set; } = null!;
        public string CuentaContable { get; set; } = null!;
        public int? Signo { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual Ratio1 CodigoNavigation { get; set; } = null!;
        public virtual CuentaContable1 CuentaContableNavigation { get; set; } = null!;
    }
}
