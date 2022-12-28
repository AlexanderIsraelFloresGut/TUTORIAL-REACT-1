using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class DocsSoporte2
    {
        public DocsSoporte2()
        {
            DesgImpuestoCh2s = new HashSet<DesgImpuestoCh2>();
            DetRetencionCh2s = new HashSet<DetRetencionCh2>();
        }

        public int Vale { get; set; }
        public int Linea { get; set; }
        public string? CentroCosto { get; set; }
        public string? CuentaContable { get; set; }
        public string? Nit { get; set; }
        public string DocSoporte { get; set; } = null!;
        public string Tipo { get; set; } = null!;
        public decimal? Monto { get; set; }
        public decimal? MontoVale { get; set; }
        public string Concepto { get; set; } = null!;
        public string? Detalle { get; set; }
        public decimal? Subtotal { get; set; }
        public decimal? Impuesto1 { get; set; }
        public decimal? Impuesto2 { get; set; }
        public decimal? Rubro1 { get; set; }
        public decimal? Rubro2 { get; set; }
        public decimal? Descuento { get; set; }
        public short? Subtipo { get; set; }
        public DateTime? Fecha { get; set; }
        public DateTime? FechaRige { get; set; }
        public string? Pais { get; set; }
        public string? DivisionGeografica1 { get; set; }
        public string? DivisionGeografica2 { get; set; }
        public string? CodigoImpuesto { get; set; }
        public decimal? BaseImpuesto1 { get; set; }
        public decimal? BaseImpuesto2 { get; set; }
        public string Imp1AfectaCosto { get; set; } = null!;
        public decimal? Imp1AsumidoDesc { get; set; }
        public decimal? Imp1AsumidoNodesc { get; set; }
        public decimal? Imp1RetenidoDesc { get; set; }
        public decimal? Imp1RetenidoNodesc { get; set; }
        public string? DocumentoFiscal { get; set; }
        public string? ConceptoMe { get; set; }
        public string? DescUbicGeografica { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
        public DateTime? FechaCai { get; set; }
        public string? Cai { get; set; }
        public string? TipoImpuesto1 { get; set; }
        public string? TipoTarifa1 { get; set; }
        public decimal? Porcentaje1 { get; set; }
        public string? TipoImpuesto2 { get; set; }
        public string? TipoTarifa2 { get; set; }
        public decimal? Porcentaje2 { get; set; }
        public string? TipoAfectacionIva { get; set; }
        public string? TipoImpuesto { get; set; }
        public string? TipoTarifa { get; set; }
        public decimal? PorcAfectacionIva { get; set; }
        public decimal? MontoTotalImpuestoAcreditar { get; set; }
        public decimal? MontoTotalDeGastoAplicable { get; set; }
        public decimal? MontoProporcionalidad { get; set; }
        public string? ClaveDe { get; set; }
        public string? GeneraDocFe { get; set; }
        public string? ActividadComercial { get; set; }
        public string? ItemHacienda { get; set; }
        public decimal? SubtotalBienes { get; set; }
        public decimal? SubtotalServicios { get; set; }
        public string? TipoDocReferencia { get; set; }
        public string? ClaveReferencia { get; set; }
        public DateTime? FechaEmisionReferencia { get; set; }
        public string? CodigoReferencia { get; set; }
        public string? RazonReferencia { get; set; }
        public string? TipoPago { get; set; }
        public string? ClaseDocEs { get; set; }
        public string? Resolucion { get; set; }
        public string? Serie { get; set; }
        public string? ControlInterno { get; set; }
        public string? SerieNumero { get; set; }

        public virtual CentroCuentum2? C { get; set; }
        public virtual Impuesto2? CodigoImpuestoNavigation { get; set; }
        public virtual ConceptoVale2 ConceptoNavigation { get; set; } = null!;
        public virtual DivisionGeografica22? DivisionGeografica22 { get; set; }
        public virtual Nit2? NitNavigation { get; set; }
        public virtual TipoPago2? TipoPagoNavigation { get; set; }
        public virtual Vale2 ValeNavigation { get; set; } = null!;
        public virtual ICollection<DesgImpuestoCh2> DesgImpuestoCh2s { get; set; }
        public virtual ICollection<DetRetencionCh2> DetRetencionCh2s { get; set; }
    }
}
