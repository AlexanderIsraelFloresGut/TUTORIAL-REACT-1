using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class ProveedorEntidad1
    {
        public string Proveedor { get; set; } = null!;
        public string EntidadFinanciera { get; set; } = null!;
        public string CuentaBanco { get; set; } = null!;
        public string? Notas { get; set; }
        public string Moneda { get; set; } = null!;
        public string? CtaDefault { get; set; }
        public string? TipoCuenta { get; set; }
        public string? CtaElectronica { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual EntidadFinanciera1 EntidadFinancieraNavigation { get; set; } = null!;
        public virtual Monedum1 MonedaNavigation { get; set; } = null!;
        public virtual Proveedor1 ProveedorNavigation { get; set; } = null!;
        public virtual TipoCuentum1? TipoCuentaNavigation { get; set; }
    }
}
