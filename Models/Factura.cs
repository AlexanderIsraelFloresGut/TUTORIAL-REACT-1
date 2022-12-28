using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class Factura
    {
        public Factura()
        {
            FacturaAduanas = new HashSet<FacturaAduana>();
            FacturaCancelas = new HashSet<FacturaCancela>();
            FacturaLineas = new HashSet<FacturaLinea>();
            FacturaRetencions = new HashSet<FacturaRetencion>();
            FiadoresDocFas = new HashSet<FiadoresDocFa>();
            GarantiasDocFas = new HashSet<GarantiasDocFa>();
            PedidoAutorizas = new HashSet<PedidoAutoriza>();
            PlanPagoDocs = new HashSet<PlanPagoDoc>();
        }

        public string TipoDocumento { get; set; } = null!;
        public string Factura1 { get; set; } = null!;
        public int? AuditTransInv { get; set; }
        public string EstaDespachado { get; set; } = null!;
        public string EnInvestigacion { get; set; } = null!;
        public string TransAdicionales { get; set; } = null!;
        public string EstadoRemision { get; set; } = null!;
        public string? AsientoDocumento { get; set; }
        public decimal DescuentoVolumen { get; set; }
        public string MonedaFactura { get; set; } = null!;
        public string? ComentarioCxc { get; set; }
        public DateTime FechaDespacho { get; set; }
        public string ClaseDocumento { get; set; } = null!;
        public DateTime FechaRecibido { get; set; }
        public string? Pedido { get; set; }
        public string? FacturaOriginal { get; set; }
        public string? TipoOriginal { get; set; }
        public decimal ComisionCobrador { get; set; }
        public string? TarjetaCredito { get; set; }
        public decimal TotalVolumen { get; set; }
        public string? NumeroAutoriza { get; set; }
        public decimal TotalPeso { get; set; }
        public decimal MontoCobrado { get; set; }
        public decimal TotalImpuesto1 { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime FechaEntrega { get; set; }
        public decimal TotalImpuesto2 { get; set; }
        public decimal PorcDescuento2 { get; set; }
        public decimal MontoFlete { get; set; }
        public decimal MontoSeguro { get; set; }
        public decimal MontoDocumentacio { get; set; }
        public string TipoDescuento1 { get; set; } = null!;
        public string TipoDescuento2 { get; set; } = null!;
        public decimal MontoDescuento1 { get; set; }
        public decimal MontoDescuento2 { get; set; }
        public decimal PorcDescuento1 { get; set; }
        public decimal TotalFactura { get; set; }
        public DateTime FechaPedido { get; set; }
        public DateTime? FechaHoraAnula { get; set; }
        public DateTime? FechaOrden { get; set; }
        public decimal TotalMercaderia { get; set; }
        public decimal ComisionVendedor { get; set; }
        public string? OrdenCompra { get; set; }
        public DateTime FechaHora { get; set; }
        public decimal TotalUnidades { get; set; }
        public short NumeroPaginas { get; set; }
        public decimal TipoCambio { get; set; }
        public string Anulada { get; set; } = null!;
        public string Modulo { get; set; } = null!;
        public string CargadoCg { get; set; } = null!;
        public string CargadoCxc { get; set; } = null!;
        public string? EmbarcarA { get; set; }
        public string? DirecEmbarque { get; set; }
        public string? DireccionFactura { get; set; }
        public short MultiplicadorEv { get; set; }
        public string? Observaciones { get; set; }
        public string? Rubro1 { get; set; }
        public string? Rubro2 { get; set; }
        public string? Rubro3 { get; set; }
        public string? Rubro4 { get; set; }
        public string? Rubro5 { get; set; }
        public int VersionNp { get; set; }
        public string Moneda { get; set; } = null!;
        public string NivelPrecio { get; set; } = null!;
        public string Cobrador { get; set; } = null!;
        public string Ruta { get; set; } = null!;
        public string Usuario { get; set; } = null!;
        public string? UsuarioAnula { get; set; }
        public string CondicionPago { get; set; } = null!;
        public string Zona { get; set; } = null!;
        public string Vendedor { get; set; } = null!;
        public string? DocCreditoCxc { get; set; }
        public string ClienteDireccion { get; set; } = null!;
        public string ClienteCorporac { get; set; } = null!;
        public string ClienteOrigen { get; set; } = null!;
        public string Cliente { get; set; } = null!;
        public string Pais { get; set; } = null!;
        public short? SubtipoDocCxc { get; set; }
        public string? TipoCreditoCxc { get; set; }
        public string? TipoDocCxc { get; set; }
        public decimal? MontoAnticipo { get; set; }
        public decimal? TotalPesoNeto { get; set; }
        public DateTime FechaRige { get; set; }
        public string? Contrato { get; set; }
        public decimal? PorcIntcte { get; set; }
        public string UsaDespachos { get; set; } = null!;
        public string Cobrada { get; set; } = null!;
        public string DescuentoCascada { get; set; } = null!;
        public string? DireccionEmbarque { get; set; }
        public string? Consecutivo { get; set; }
        public int Reimpreso { get; set; }
        public string? DivisionGeografica1 { get; set; }
        public string? DivisionGeografica2 { get; set; }
        public decimal? BaseImpuesto1 { get; set; }
        public decimal? BaseImpuesto2 { get; set; }
        public string? NombreCliente { get; set; }
        public string? DocFiscal { get; set; }
        public string? Nombremaquina { get; set; }
        public string? SerieResolucion { get; set; }
        public int? ConsecResolucion { get; set; }
        public string GeneraDocFe { get; set; } = null!;
        public string? TasaImpositiva { get; set; }
        public decimal? TasaImpositivaPorc { get; set; }
        public string? TasaCree1 { get; set; }
        public decimal? TasaCree1Porc { get; set; }
        public string? TasaCree2 { get; set; }
        public decimal? TasaCree2Porc { get; set; }
        public decimal? TasaGanOcasionalPorc { get; set; }
        public string? ContratoAc { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
        public decimal? AjusteRedondeo { get; set; }
        public string? UsoCfdi { get; set; }
        public string? FormaPago { get; set; }
        public string? ClaveReferenciaDe { get; set; }
        public DateTime? FechaReferenciaDe { get; set; }
        public string? JustiDevHaciend { get; set; }
        public string? TipoOperacion { get; set; }
        public string? Incoterms { get; set; }
        public string? UAdWmNumeroVendedor { get; set; }
        public string? UAdWmEnviarGln { get; set; }
        public string? UAdWmNumeroRecepcion { get; set; }
        public string? UAdWmNumeroReclamo { get; set; }
        public string? UAdWmFechaReclamo { get; set; }
        public string? UAdPcNumeroVendedor { get; set; }
        public string? UAdPcEnviarGln { get; set; }
        public string? UAdGsNumeroVendedor { get; set; }
        public string? UAdGsEnviarGln { get; set; }
        public string? UAdGsNumeroRecepcion { get; set; }
        public string? UAdGsFechaRecepcion { get; set; }
        public string? UAdAmNumeroProveedor { get; set; }
        public string? UAdAmEnviarGln { get; set; }
        public string? UAdAmNumeroRecepcion { get; set; }
        public string? UAdAmNumeroReclamo { get; set; }
        public string? UAdAmFechaReclamo { get; set; }
        public string? UAdAmFechaRecepcion { get; set; }
        public string? UAdCcRemision { get; set; }
        public DateTime? UAdCcFechaConsumo { get; set; }
        public string? UAdCcHojaEntrada { get; set; }
        public string? ClaveDe { get; set; }
        public string? ActividadComercial { get; set; }
        public decimal? MontoOtroCargo { get; set; }
        public decimal? MontoTotalIvaDevuelto { get; set; }
        public string? CodigoReferenciaDe { get; set; }
        public string? TipoReferenciaDe { get; set; }
        public string? Cancelacion { get; set; }
        public string? EstadoCancelacion { get; set; }
        public string? TieneRelacionados { get; set; }
        public string? Prefijo { get; set; }
        public DateTime? FechaInicioResolucion { get; set; }
        public DateTime? FechaFinalResolucion { get; set; }
        public string? ClaveTecnica { get; set; }
        public int? MatriculaMercantil { get; set; }
        public string? EsFacturaReemplazo { get; set; }
        public string? FacturaOriginalReemplazo { get; set; }
        public string? ConsecutivoFtc { get; set; }
        public string? NumeroFtc { get; set; }
        public string? NitTransportador { get; set; }
        public string? NcfModificado { get; set; }
        public string? NumOcExenta { get; set; }
        public string? NumConsRegExo { get; set; }
        public string? NumIrsedeAgrGan { get; set; }
        public string? UAdWmTipoNc { get; set; }
        public string? CuentaAsiento { get; set; }
        public string? TipoPago { get; set; }
        public string? TipoDescuentoGlobal { get; set; }
        public string? TipoFactura { get; set; }
        public string? TipoNc { get; set; }
        public string? TipoDetrac { get; set; }
        public string? ActDetrac { get; set; }
        public decimal? PorcDetrac { get; set; }
        public string? GuuidOriginal { get; set; }

        public virtual Cliente ClienteCorporacNavigation { get; set; } = null!;
        public virtual Cliente ClienteDireccionNavigation { get; set; } = null!;
        public virtual Cliente ClienteNavigation { get; set; } = null!;
        public virtual Cliente ClienteOrigenNavigation { get; set; } = null!;
        public virtual Cobrador CobradorNavigation { get; set; } = null!;
        public virtual CondicionPago CondicionPagoNavigation { get; set; } = null!;
        public virtual DocumentosCc? DocumentosCc { get; set; }
        public virtual NivelPrecio NivelPrecioNavigation { get; set; } = null!;
        public virtual Pai PaisNavigation { get; set; } = null!;
        public virtual Rutum RutaNavigation { get; set; } = null!;
        public virtual SubtipoDocCc? SubtipoDocCc { get; set; }
        public virtual TipoDescuento? TipoDescuentoGlobalNavigation { get; set; }
        public virtual TipoFactura? TipoFacturaNavigation { get; set; }
        public virtual TipoNc? TipoNcNavigation { get; set; }
        public virtual TipoPago? TipoPagoNavigation { get; set; }
        public virtual TiposDetraccione? TiposDetraccione { get; set; }
        public virtual Usuario2? UsuarioAnulaNavigation { get; set; }
        public virtual Usuario2 UsuarioNavigation { get; set; } = null!;
        public virtual Vendedor VendedorNavigation { get; set; } = null!;
        public virtual Zona ZonaNavigation { get; set; } = null!;
        public virtual ICollection<FacturaAduana> FacturaAduanas { get; set; }
        public virtual ICollection<FacturaCancela> FacturaCancelas { get; set; }
        public virtual ICollection<FacturaLinea> FacturaLineas { get; set; }
        public virtual ICollection<FacturaRetencion> FacturaRetencions { get; set; }
        public virtual ICollection<FiadoresDocFa> FiadoresDocFas { get; set; }
        public virtual ICollection<GarantiasDocFa> GarantiasDocFas { get; set; }
        public virtual ICollection<PedidoAutoriza> PedidoAutorizas { get; set; }
        public virtual ICollection<PlanPagoDoc> PlanPagoDocs { get; set; }
    }
}
