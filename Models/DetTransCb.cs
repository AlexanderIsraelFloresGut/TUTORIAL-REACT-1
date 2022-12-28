using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class DetTransCb
    {
        public decimal Consecutivo { get; set; }
        public string CuentaOrigen { get; set; } = null!;
        public string TipoOrigen { get; set; } = null!;
        public decimal NumeroOrigen { get; set; }
        public string CuentaDestino { get; set; } = null!;
        public string TipoDestino { get; set; } = null!;
        public decimal NumeroDestino { get; set; }
        public decimal? MontoComision { get; set; }
        public decimal? TipoCambio { get; set; }
        public decimal MontoOrigen { get; set; }
        public decimal MontoDestino { get; set; }
        public string CompaniaDestino { get; set; } = null!;
        public string? TipoMov { get; set; }
        public string? Beneficiario { get; set; }
        public string? Contribuyente { get; set; }
        public string? Concepto { get; set; }
        public string? EntidadFinanciera { get; set; }
        public string? Moneda { get; set; }
        public string? Rubro1Dettrans { get; set; }
        public string? Rubro2Dettrans { get; set; }
        public string? Rubro3Dettrans { get; set; }
        public string? Rubro4Dettrans { get; set; }
        public string? Rubro5Dettrans { get; set; }
        public string? Rubro6Dettrans { get; set; }
        public string? Rubro7Dettrans { get; set; }
        public string? Rubro8Dettrans { get; set; }
        public string? Rubro9Dettrans { get; set; }
        public string? Rubro10Dettrans { get; set; }
        public string? CtrCierreTerceros { get; set; }
        public string? CtaCierreTerceros { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
        public string? MetodoPago { get; set; }

        public virtual EntidadFinanciera? EntidadFinancieraNavigation { get; set; }
        public virtual MetodoPago? MetodoPagoNavigation { get; set; }
        public virtual Monedum? MonedaNavigation { get; set; }
        public virtual TransferenciaCb TransferenciaCb { get; set; } = null!;
    }
}
