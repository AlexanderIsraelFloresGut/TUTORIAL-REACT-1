using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class GlobalesFa2
    {
        public short? Llave { get; set; }
        public string? BodegaDefault { get; set; }
        public string? CondPagoContad { get; set; }
        public string? VendedorObligator { get; set; }
        public string FactExcPedido { get; set; } = null!;
        public string UsaTarjetaCred { get; set; } = null!;
        public string BodegaPorLinea { get; set; } = null!;
        public string PermiteBackorder { get; set; } = null!;
        public string? CancelPedParcial { get; set; }
        public string PedAImpresora { get; set; } = null!;
        public string DocAImpresora { get; set; } = null!;
        public string? ImpreLoteSeparad { get; set; }
        public string? FacturaMultipag { get; set; }
        public string? IncrNumFactura { get; set; }
        public string MultipleFmtFactu { get; set; } = null!;
        public string MultipleFmtPedid { get; set; } = null!;
        public string OrdenLineasFact { get; set; } = null!;
        public string ReimpresionPedido { get; set; } = null!;
        public string ImpPedidoAlFact { get; set; } = null!;
        public string RedondearFactura { get; set; } = null!;
        public decimal FactorRedondeo { get; set; }
        public short PreciosDec { get; set; }
        public string DescEnPrecio { get; set; } = null!;
        public string? Imp1EnPrecio { get; set; }
        public string Imp1AfectaDescto { get; set; } = null!;
        public string? AplicaNiPrImp1 { get; set; }
        public string? MonedaImp1 { get; set; }
        public string? NivPrecioImp1 { get; set; }
        public string? PagoComParcial { get; set; }
        public decimal? PorcImpComision { get; set; }
        public string AsientoVentaPor { get; set; } = null!;
        public string? TipoAsiento { get; set; }
        public string? Paquete { get; set; }
        public string? CtrFlete { get; set; }
        public string? CtaFlete { get; set; }
        public string? CtrSeguro { get; set; }
        public string? CtaSeguro { get; set; }
        public string? CtrDocumentaci { get; set; }
        public string? CtaDocumentaci { get; set; }
        public string? CtrImpuesto1 { get; set; }
        public string? CtaImpuesto1 { get; set; }
        public string? CtrImpuesto2 { get; set; }
        public string? CtaImpuesto2 { get; set; }
        public string? CtrImpComisio { get; set; }
        public string? CtaImpComisio { get; set; }
        public string UsarRubros { get; set; } = null!;
        public string? Rubro1Nombre { get; set; }
        public string? Rubro2Nombre { get; set; }
        public string? Rubro3Nombre { get; set; }
        public string? Rubro4Nombre { get; set; }
        public string UsaBoletas { get; set; } = null!;
        public string? NomRubro6Cli { get; set; }
        public string? NomRubro7Cli { get; set; }
        public string? NomRubro8Cli { get; set; }
        public string? NomRubro9Cli { get; set; }
        public string? Rubro5Nombre { get; set; }
        public string? Observaciones { get; set; }
        public string? NivPrePublico { get; set; }
        public string? MonedaPublico { get; set; }
        public string? ColumnasEstandar { get; set; }
        public string AsientoCostoPor { get; set; } = null!;
        public string CambiarEsqTrab { get; set; } = null!;
        public string FactDocsVencidos { get; set; } = null!;
        public string FactCobroJud { get; set; } = null!;
        public string FactLimiteCred { get; set; } = null!;
        public short ModAplicAsiento { get; set; }
        public string IntegracionConta { get; set; } = null!;
        public string TipoContaOmision { get; set; } = null!;
        public string? TipoCambio { get; set; }
        public string? PrecisionMaxima { get; set; }
        public short LineasArticulo { get; set; }
        public short LineasFactura { get; set; }
        public short LineasAdicionales { get; set; }
        public string DetalleKits { get; set; } = null!;
        public string ModPrecios { get; set; } = null!;
        public string? Prevista1 { get; set; }
        public string? Prevista2 { get; set; }
        public string? Prevista3 { get; set; }
        public string? Prevista4 { get; set; }
        public string? Prevista5 { get; set; }
        public string? CtrConsumo { get; set; }
        public string CcEnLinea { get; set; } = null!;
        public string CgEnLinea { get; set; } = null!;
        public string UsarAutorizacion { get; set; } = null!;
        public string Imp1EnBonifica { get; set; } = null!;
        public string Imp2EnBonifica { get; set; } = null!;
        public string AsientoContcxcpor { get; set; } = null!;
        public string UsarAprobPedidos { get; set; } = null!;
        public string? NomRubro10Cli { get; set; }
        public string ListaPrecios { get; set; } = null!;
        public string MargenUtilidad { get; set; } = null!;
        public string MontoMinimo { get; set; } = null!;
        public string DocsVencidos { get; set; } = null!;
        public string LimiteCredito { get; set; } = null!;
        public string CobroJudicial { get; set; } = null!;
        public string SinOc { get; set; } = null!;
        public string DiasAtraso { get; set; } = null!;
        public decimal? MontoMinimoLocal { get; set; }
        public decimal? MontoMinimoDolar { get; set; }
        public decimal? SaldoMaxLocal { get; set; }
        public decimal? SaldoMaxDolar { get; set; }
        public short? MaxDiasAtraso { get; set; }
        public short? MaxDocsVenc { get; set; }
        public short PreciosDecDolar { get; set; }
        public string CondPagoNivPre { get; set; } = null!;
        public string FactListaPrecios { get; set; } = null!;
        public string FactMargenUtilid { get; set; } = null!;
        public string FactMontoMinimo { get; set; } = null!;
        public string FactDiasAtraso { get; set; } = null!;
        public string FactSinOc { get; set; } = null!;
        public string UsarRubrosVal { get; set; } = null!;
        public string ImpDescClasific { get; set; } = null!;
        public string? LimitarMaxLineas { get; set; }
        public string IndicadPedido { get; set; } = null!;
        public string PrecioCosto { get; set; } = null!;
        public string FactMenorReserva { get; set; } = null!;
        public string UsaDespachos { get; set; } = null!;
        public string? CtrInvDespachar { get; set; }
        public string? CtaInvDespachar { get; set; }
        public string AnulaCxcAplicado { get; set; } = null!;
        public string UsaEsquemaCajas { get; set; } = null!;
        public string TipoCostoNoexist { get; set; } = null!;
        public string CalculoImp2 { get; set; } = null!;
        public string CategoriaCliente { get; set; } = null!;
        public string NivelPrecio { get; set; } = null!;
        public string MonedaNivel { get; set; } = null!;
        public string DescuentoCascada { get; set; } = null!;
        public string? Retenciones { get; set; }
        public string? RetencionesFletes { get; set; }
        public string? Articulo { get; set; }
        public string? CodigoRetencion { get; set; }
        public string AplicarDescGen { get; set; } = null!;
        public string ModoDescMult { get; set; } = null!;
        public string DctoGeneral { get; set; } = null!;
        public string FactDctoGeneral { get; set; } = null!;
        public string AutorGrabar { get; set; } = null!;
        public string AutorAprobar { get; set; } = null!;
        public string AutorFacturemitir { get; set; } = null!;
        public string AutorFactremision { get; set; } = null!;
        public string CargarAprobadoCc { get; set; } = null!;
        public string RemisionAImpres { get; set; } = null!;
        public string DevolucAImpres { get; set; } = null!;
        public string? NomRubro16Cli { get; set; }
        public string? NomRubro17Cli { get; set; }
        public string? NomRubro18Cli { get; set; }
        public string? NomRubro19Cli { get; set; }
        public string? NomRubro20Cli { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
        public string CreaNuevoCliente { get; set; } = null!;

        public virtual Bodega2? BodegaDefaultNavigation { get; set; }
        public virtual CategoriaCliente2 CategoriaClienteNavigation { get; set; } = null!;
        public virtual CondicionPago2? CondPagoContadNavigation { get; set; }
        public virtual CentroCuentum2? Ct { get; set; }
        public virtual CentroCuentum2? Ct1 { get; set; }
        public virtual CentroCuentum2? Ct2 { get; set; }
        public virtual CentroCuentum2? Ct3 { get; set; }
        public virtual CentroCuentum2? Ct4 { get; set; }
        public virtual CentroCuentum2? Ct5 { get; set; }
        public virtual CentroCuentum2? CtNavigation { get; set; }
        public virtual CentroCosto2? CtrConsumoNavigation { get; set; }
        public virtual NivelPrecio2? NivelPrecio2 { get; set; }
        public virtual NivelPrecio2 NivelPrecio2Navigation { get; set; } = null!;
        public virtual Paquete2? PaqueteNavigation { get; set; }
        public virtual TipoAsiento2? TipoAsientoNavigation { get; set; }
        public virtual TipoCambio2? TipoCambioNavigation { get; set; }
    }
}
