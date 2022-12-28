using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class CuentaRubroDesg1
    {
        public string Rubro { get; set; } = null!;
        public string CentroCostoRubro { get; set; } = null!;
        public string CuentaContableRubro { get; set; } = null!;
        public decimal Porcentaje { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual CentroCuentum1 C { get; set; } = null!;
        public virtual RubroLiq1 RubroNavigation { get; set; } = null!;
    }
}
