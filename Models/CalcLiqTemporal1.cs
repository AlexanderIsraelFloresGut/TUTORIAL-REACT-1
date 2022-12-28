using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class CalcLiqTemporal1
    {
        public string Liquidacion { get; set; } = null!;
        public string OrdenProduccion { get; set; } = null!;
        public string Operacion { get; set; } = null!;
        public DateTime FechaHoraProduc { get; set; }
        public string Rubro { get; set; } = null!;
        public string CentroCosto { get; set; } = null!;
        public string CuentaContable { get; set; } = null!;
        public decimal MontoContLocal { get; set; }
        public decimal? MontoContDolar { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
    }
}
