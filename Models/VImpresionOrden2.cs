using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class VImpresionOrden2
    {
        public string Usuario { get; set; } = null!;
        public string OrdenCompra { get; set; } = null!;
        public short OrdenCompraLinea { get; set; }
        public string Proveedor { get; set; } = null!;
        public string NombreProveedor { get; set; } = null!;
        public string TelefonoProveedor { get; set; } = null!;
        public string FaxProveedor { get; set; } = null!;
        public string DireccionProveedor { get; set; } = null!;
        public string Pais { get; set; } = null!;
        public string NombrePais { get; set; } = null!;
        public string CondicionPago { get; set; } = null!;
        public string DescripcionCondPago { get; set; } = null!;
        public string Moneda { get; set; } = null!;
        public string NombreMoneda { get; set; } = null!;
        public string? DireccionEmbarque { get; set; }
        public string? DireccionCobro { get; set; }
        public string? Instrucciones { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime? FechaCotizacion { get; set; }
        public DateTime? FechaOfrecida { get; set; }
        public DateTime? FechaReqEmbarque { get; set; }
        public DateTime FechaRequerida { get; set; }
        public string Prioridad { get; set; } = null!;
        public string Articulo { get; set; } = null!;
        public string? CodigoCatalogo { get; set; }
        public string? UnidadMedidaComp { get; set; }
        public string? DescripcionArtOclin { get; set; }
        public string? DescripcionArtCompraOc { get; set; }
        public string DescripcionArticulo { get; set; } = null!;
        public decimal CantidadOrdenada { get; set; }
        public decimal PrecioUnitario { get; set; }
        public decimal MontoDescuentoLinea { get; set; }
        public decimal PorcDescuentoLinea { get; set; }
        public string? Comentario { get; set; }
        public decimal TotalMercaderiaOrden { get; set; }
        public decimal? MontoDescuentoOrden { get; set; }
        public decimal PorcDescuentoOrden { get; set; }
        public decimal MontoFlete { get; set; }
        public decimal MontoSeguro { get; set; }
        public decimal MontoDocumentacio { get; set; }
        public decimal MontoAnticipo { get; set; }
        public decimal TotalImpuesto1Orden { get; set; }
        public decimal TotalImpuesto2Orden { get; set; }
        public decimal TotalAComprarOrden { get; set; }
        public string? Rubro1 { get; set; }
        public string? Rubro2 { get; set; }
        public string? Rubro3 { get; set; }
        public string? Rubro4 { get; set; }
        public string? Rubro5 { get; set; }
        public string? Observaciones { get; set; }
        public string RequiereConfirma { get; set; } = null!;
        public string Confirmada { get; set; } = null!;
        public string UnidadAlmacen { get; set; } = null!;
        public string Bodega { get; set; } = null!;
        public string? ResponSeguimiento { get; set; }
        public string ModuloOrigen { get; set; } = null!;
        public DateTime? FechaEmision { get; set; }
        public string TipoDescuento { get; set; } = null!;
        public string Estado { get; set; } = null!;
        public string Impresa { get; set; } = null!;
        public string? NumFormulario { get; set; }
        public string? ComentarioCxp { get; set; }
        public DateTime FechaHora { get; set; }
        public string? UsuarioConfirma { get; set; }
        public DateTime? FechaHoraConfir { get; set; }
        public string? UsuarioCierre { get; set; }
        public DateTime? FechaHoraCierre { get; set; }
        public string? AsientoCierre { get; set; }
        public decimal CantidadEmbarcada { get; set; }
        public decimal CantidadRecibida { get; set; }
        public decimal CantidadRechazada { get; set; }
        public decimal Impuesto1 { get; set; }
        public decimal Impuesto2 { get; set; }
        public decimal? FactorConversion { get; set; }
        public string? CodigoArancel { get; set; }
        public DateTime FechaRequerida1 { get; set; }
        public DateTime? FecEmbarqueProv { get; set; }
        public short? DiasParaEntrega { get; set; }
        public string? Factura { get; set; }
        public string? CodigoBarrasInvt { get; set; }
        public string? CentroCosto { get; set; }
        public string? CuentaContable { get; set; }
        public string Contacto { get; set; } = null!;
        public string Local { get; set; } = null!;
        public decimal? Transito { get; set; }
        public string BodegaLinea { get; set; } = null!;
    }
}
