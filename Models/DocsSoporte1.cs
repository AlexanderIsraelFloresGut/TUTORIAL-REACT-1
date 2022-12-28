using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class DocsSoporte1
    {
        public DocsSoporte1()
        {
            DesgImpuestoCh1s = new HashSet<DesgImpuestoCh1>();
            DetRetencionCh1s = new HashSet<DetRetencionCh1>();
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
        public string? Moneda { get; set; }
        public decimal? MontoLocal { get; set; }
        public decimal? MontoDolar { get; set; }
        public decimal? TipoCambio { get; set; }
        public string? ActDet { get; set; }
        public string? CodigoDet { get; set; }
        public string? TipoDet { get; set; }
        public string? NumeroDet { get; set; }
        public decimal? ImporteDet { get; set; }
        public string? NumContDet { get; set; }
        public DateTime? FechaConDet { get; set; }
        public string PagoDet { get; set; } = null!;
        public string? Usuario { get; set; }
        public string? TipoOperacion { get; set; }
        public string? FormaPago { get; set; }
        public string? Incoterms { get; set; }
        public string? Cufe { get; set; }
        public string? Codigoqr { get; set; }

        public virtual CentroCuentum1? C { get; set; }
        public virtual Impuesto1? CodigoImpuestoNavigation { get; set; }
        public virtual ConceptoVale1 ConceptoNavigation { get; set; } = null!;
        public virtual DivisionGeografica21? DivisionGeografica21 { get; set; }
        public virtual Monedum1? MonedaNavigation { get; set; }
        public virtual Nit1? NitNavigation { get; set; }
        public virtual NaturalezaOperacion? TipoOperacionNavigation { get; set; }
        public virtual TipoPago1? TipoPagoNavigation { get; set; }
        public virtual Usuario2? UsuarioNavigation { get; set; }
        public virtual Vale1 ValeNavigation { get; set; } = null!;
        public virtual ICollection<DesgImpuestoCh1> DesgImpuestoCh1s { get; set; }
        public virtual ICollection<DetRetencionCh1> DetRetencionCh1s { get; set; }
    }
}
