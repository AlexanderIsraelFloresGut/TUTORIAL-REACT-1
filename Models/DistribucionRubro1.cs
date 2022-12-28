using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class DistribucionRubro1
    {
        public string Liquidacion { get; set; } = null!;
        public string Rubro { get; set; } = null!;
        public string CentroCostoOrigen { get; set; } = null!;
        public string CuentaContableOrigen { get; set; } = null!;
        public string CentroCostoRubro { get; set; } = null!;
        public string CuentaContableRubro { get; set; } = null!;
        public decimal Porcentaje { get; set; }
        public decimal MontoDisLocal { get; set; }
        public decimal MontoDisDolar { get; set; }
        public string Asiento { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual RubroLiq1 RubroNavigation { get; set; } = null!;
    }
}
