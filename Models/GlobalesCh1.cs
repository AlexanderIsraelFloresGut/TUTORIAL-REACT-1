using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class GlobalesCh1
    {
        public string ImpuestoOmision { get; set; } = null!;
        public string? TipoAsiento { get; set; }
        public string? Paquete { get; set; }
        public string? CentroCostoAd { get; set; }
        public string? CuentaContableAd { get; set; }
        public string IntegracionCg { get; set; } = null!;
        public string IntegracionCb { get; set; } = null!;
        public short? ModAplicAsiento { get; set; }
        public string? TipoContaOmision { get; set; }
        public string? Detalle { get; set; }
        public string? AsientoVale { get; set; }
        public string? CtrRubro1Ch { get; set; }
        public string? CtaRubro1Ch { get; set; }
        public string? CtrRubro2Ch { get; set; }
        public string? CtaRubro2Ch { get; set; }
        public string? CtrImpuesto1Ch { get; set; }
        public string? CtaImpuesto1Ch { get; set; }
        public string? CtrImpuesto2Ch { get; set; }
        public string? CtaImpuesto2Ch { get; set; }
        public string? IntegracionCr { get; set; }
        public string? PaqueteCr { get; set; }
        public string? PresupuestoCr { get; set; }
        public string? RequierePresup { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual CentroCuentum1? C { get; set; }
        public virtual CentroCuentum1? Ct { get; set; }
        public virtual CentroCuentum1? Ct1 { get; set; }
        public virtual CentroCuentum1? Ct2 { get; set; }
        public virtual CentroCuentum1? CtNavigation { get; set; }
        public virtual Impuesto1 ImpuestoOmisionNavigation { get; set; } = null!;
        public virtual Paquete1? PaqueteNavigation { get; set; }
        public virtual TipoAsiento1? TipoAsientoNavigation { get; set; }
    }
}
