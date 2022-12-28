using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class VLineasAsiento
    {
        public string Tabla { get; set; } = null!;
        public string Asiento { get; set; } = null!;
        public int Consecutivo { get; set; }
        public string Correlativo { get; set; } = null!;
        public string? Nit { get; set; }
        public string CentroCosto { get; set; } = null!;
        public string CuentaContable { get; set; } = null!;
        public string Fuente { get; set; } = null!;
        public string Referencia { get; set; } = null!;
        public decimal? DebitoLocal { get; set; }
        public decimal? CreditoLocal { get; set; }
        public decimal? DebitoDolar { get; set; }
        public decimal? CreditoDolar { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreatedBy { get; set; } = null!;
        public Guid RowPointer { get; set; }
    }
}
