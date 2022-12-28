using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class Pedido1
    {
        public Pedido1()
        {
            FiadoresPedFa1s = new HashSet<FiadoresPedFa1>();
            GarantiasPedFa1s = new HashSet<GarantiasPedFa1>();
            PedidoAutoriza1s = new HashSet<PedidoAutoriza1>();
            PedidoLinea1s = new HashSet<PedidoLinea1>();
            PedidoOrdenProduc1s = new HashSet<PedidoOrdenProduc1>();
            PlanPagoPed1s = new HashSet<PlanPagoPed1>();
        }

        public string Pedido { get; set; } = null!;
        public string Estado { get; set; } = null!;
        public DateTime FechaPedido { get; set; }
        public DateTime FechaPrometida { get; set; }
        public DateTime FechaProxEmbarqu { get; set; }
        public DateTime? FechaUltEmbarque { get; set; }
        public DateTime? FechaUltCancelac { get; set; }
        public string? OrdenCompra { get; set; }
        public DateTime? FechaOrden { get; set; }
        public string? TarjetaCredito { get; set; }
        public string? EmbarcarA { get; set; }
        public string DirecEmbarque { get; set; } = null!;
        public string DireccionFactura { get; set; } = null!;
        public string? Rubro1 { get; set; }
        public string? Rubro2 { get; set; }
        public string? Rubro3 { get; set; }
        public string? Rubro4 { get; set; }
        public string? Rubro5 { get; set; }
        public string? Observaciones { get; set; }
        public string? ComentarioCxc { get; set; }
        public decimal TotalMercaderia { get; set; }
        public decimal MontoAnticipo { get; set; }
        public decimal MontoFlete { get; set; }
        public decimal MontoSeguro { get; set; }
        public decimal MontoDocumentacio { get; set; }
        public string TipoDescuento1 { get; set; } = null!;
        public string TipoDescuento2 { get; set; } = null!;
        public decimal MontoDescuento1 { get; set; }
        public decimal MontoDescuento2 { get; set; }
        public decimal PorcDescuento1 { get; set; }
        public decimal PorcDescuento2 { get; set; }
        public decimal TotalImpuesto1 { get; set; }
        public decimal TotalImpuesto2 { get; set; }
        public decimal TotalAFacturar { get; set; }
        public decimal PorcComiVendedor { get; set; }
        public decimal PorcComiCobrador { get; set; }
        public decimal TotalCancelado { get; set; }
        public decimal TotalUnidades { get; set; }
        public string Impreso { get; set; } = null!;
        public DateTime FechaHora { get; set; }
        public decimal DescuentoVolumen { get; set; }
        public string TipoPedido { get; set; } = null!;
        public string MonedaPedido { get; set; } = null!;
        public int VersionNp { get; set; }
        public string Autorizado { get; set; } = null!;
        public string DocAGenerar { get; set; } = null!;
        public string ClasePedido { get; set; } = null!;
        public string Moneda { get; set; } = null!;
        public string NivelPrecio { get; set; } = null!;
        public string Cobrador { get; set; } = null!;
        public string Ruta { get; set; } = null!;
        public string Usuario { get; set; } = null!;
        public string CondicionPago { get; set; } = null!;
        public string Bodega { get; set; } = null!;
        public string Zona { get; set; } = null!;
        public string Vendedor { get; set; } = null!;
        public string Cliente { get; set; } = null!;
        public string ClienteDireccion { get; set; } = null!;
        public string ClienteCorporac { get; set; } = null!;
        public string ClienteOrigen { get; set; } = null!;
        public string Pais { get; set; } = null!;
        public short? SubtipoDocCxc { get; set; }
        public string? TipoDocCxc { get; set; }
        public string Backorder { get; set; } = null!;
        public string? Contrato { get; set; }
        public decimal? PorcIntcte { get; set; }
        public string DescuentoCascada { get; set; } = null!;
        public decimal? TipoCambio { get; set; }
        public string FijarTipoCambio { get; set; } = null!;
        public string OrigenPedido { get; set; } = null!;
        public string? DescDirecEmbarque { get; set; }
        public string? DivisionGeografica1 { get; set; }
        public string? DivisionGeografica2 { get; set; }
        public decimal? BaseImpuesto1 { get; set; }
        public decimal? BaseImpuesto2 { get; set; }
        public string? NombreCliente { get; set; }
        public DateTime? FechaProyectada { get; set; }
        public DateTime? FechaAprobacion { get; set; }
        public string TipoDocumento { get; set; } = null!;
        public string? VersionCotizacion { get; set; }
        public string? RazonCancelaCoti { get; set; }
        public string? DesCancelaCoti { get; set; }
        public string? CambiosCoti { get; set; }
        public string? CotizacionPadre { get; set; }
        public string? TasaImpositiva { get; set; }
        public decimal? TasaImpositivaPorc { get; set; }
        public string? TasaCree1 { get; set; }
        public decimal? TasaCree1Porc { get; set; }
        public string? TasaCree2 { get; set; }
        public decimal? TasaCree2Porc { get; set; }
        public decimal? TasaGanOcasionalPorc { get; set; }
        public string? ContratoAc { get; set; }
        public string? TipoContratoAc { get; set; }
        public string? PeriodicidadContratoAc { get; set; }
        public DateTime? FechaContratoAc { get; set; }
        public DateTime? FechaInicioContratoAc { get; set; }
        public DateTime? FechaProxfacContratoAc { get; set; }
        public DateTime? FechaFinfacContratoAc { get; set; }
        public DateTime? FechaUltaumentoContratoAc { get; set; }
        public DateTime? FechaProxfacsistContratoAc { get; set; }
        public string? DiferidoContratoAc { get; set; }
        public decimal? TotalContratoAc { get; set; }
        public string? ContratoReventa { get; set; }
        public string? UsrNoAprueba { get; set; }
        public DateTime? FechaNoAprueba { get; set; }
        public string? RazonDesaprueba { get; set; }
        public string? Modulo { get; set; }
        public string? CorreosEnvio { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
        public DateTime? ContratoVigenciaDesde { get; set; }
        public DateTime? ContratoVigenciaHasta { get; set; }
        public string? UsoCfdi { get; set; }
        public string? FormaPago { get; set; }
        public string? ClaveReferenciaDe { get; set; }
        public DateTime? FechaReferenciaDe { get; set; }
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
        public string? ActividadComercial { get; set; }
        public decimal? MontoOtroCargo { get; set; }
        public string? CodigoReferenciaDe { get; set; }
        public string? TipoReferenciaDe { get; set; }
        public string? TieneRelacionados { get; set; }
        public string? EsFacturaReemplazo { get; set; }
        public string? FacturaOriginalReemplazo { get; set; }
        public string? ConsecutivoFtc { get; set; }
        public string? NumeroFtc { get; set; }
        public string? NitTransportador { get; set; }
        public string? NumOcExenta { get; set; }
        public string? NumConsRegExo { get; set; }
        public string? NumIrsedeAgrGan { get; set; }
        public string? TipoPago { get; set; }
        public string? TipoDescuentoGlobal { get; set; }
        public string? TipoFactura { get; set; }

        public virtual Bodega1 BodegaNavigation { get; set; } = null!;
        public virtual Cliente1 ClienteCorporacNavigation { get; set; } = null!;
        public virtual Cliente1 ClienteDireccionNavigation { get; set; } = null!;
        public virtual Cliente1 ClienteNavigation { get; set; } = null!;
        public virtual Cliente1 ClienteOrigenNavigation { get; set; } = null!;
        public virtual Cobrador1 CobradorNavigation { get; set; } = null!;
        public virtual CondicionPago1 CondicionPagoNavigation { get; set; } = null!;
        public virtual NivelPrecio1 NivelPrecio1 { get; set; } = null!;
        public virtual Pai1 PaisNavigation { get; set; } = null!;
        public virtual CancelacionCotizacione1? RazonCancelaCotiNavigation { get; set; }
        public virtual Rutum1 RutaNavigation { get; set; } = null!;
        public virtual SubtipoDocCc1? SubtipoDocCc1 { get; set; }
        public virtual TipoDescuento1? TipoDescuentoGlobalNavigation { get; set; }
        public virtual TipoFactura1? TipoFacturaNavigation { get; set; }
        public virtual TipoPago1? TipoPagoNavigation { get; set; }
        public virtual Usuario2 UsuarioNavigation { get; set; } = null!;
        public virtual Vendedor1 VendedorNavigation { get; set; } = null!;
        public virtual Zona1 ZonaNavigation { get; set; } = null!;
        public virtual MonedaPedBackord1 MonedaPedBackord1 { get; set; } = null!;
        public virtual ICollection<FiadoresPedFa1> FiadoresPedFa1s { get; set; }
        public virtual ICollection<GarantiasPedFa1> GarantiasPedFa1s { get; set; }
        public virtual ICollection<PedidoAutoriza1> PedidoAutoriza1s { get; set; }
        public virtual ICollection<PedidoLinea1> PedidoLinea1s { get; set; }
        public virtual ICollection<PedidoOrdenProduc1> PedidoOrdenProduc1s { get; set; }
        public virtual ICollection<PlanPagoPed1> PlanPagoPed1s { get; set; }
    }
}
