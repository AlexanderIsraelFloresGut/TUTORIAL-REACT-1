using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class PedidoLinea
    {
        public string Pedido { get; set; } = null!;
        public short PedidoLinea1 { get; set; }
        public string Bodega { get; set; } = null!;
        public string? Lote { get; set; }
        public string? Localizacion { get; set; }
        public string Articulo { get; set; } = null!;
        public string Estado { get; set; } = null!;
        public DateTime FechaEntrega { get; set; }
        public short LineaUsuario { get; set; }
        public decimal PrecioUnitario { get; set; }
        public decimal CantidadPedida { get; set; }
        public decimal CantidadAFactura { get; set; }
        public decimal CantidadFacturada { get; set; }
        public decimal CantidadReservada { get; set; }
        public decimal CantidadBonificad { get; set; }
        public decimal CantidadCancelada { get; set; }
        public string TipoDescuento { get; set; } = null!;
        public decimal MontoDescuento { get; set; }
        public decimal PorcDescuento { get; set; }
        public string? Descripcion { get; set; }
        public string? Comentario { get; set; }
        public short? PedidoLineaBonif { get; set; }
        public string? UnidadDistribucio { get; set; }
        public DateTime FechaPrometida { get; set; }
        public int? LineaOrdenCompra { get; set; }
        public string? Proyecto { get; set; }
        public string? Fase { get; set; }
        public string? CentroCosto { get; set; }
        public string? CuentaContable { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
        public string? RazonPerdida { get; set; }
        public string? TipoDesc { get; set; }
        public string? TipoImpuesto1 { get; set; }
        public string? TipoTarifa1 { get; set; }
        public string? TipoImpuesto2 { get; set; }
        public string? TipoTarifa2 { get; set; }
        public decimal? PorcExoneracion { get; set; }
        public decimal? MontoExoneracion { get; set; }
        public decimal? PorcImpuesto1 { get; set; }
        public decimal? PorcImpuesto2 { get; set; }
        public string? EsOtroCargo { get; set; }
        public string? EsCanastaBasica { get; set; }
        public decimal? PorcExoneracion2 { get; set; }
        public decimal? MontoExoneracion2 { get; set; }
        public decimal? PorcImp1Base { get; set; }
        public decimal? PorcImp2Base { get; set; }
        public string? TipoDescuentoLinea { get; set; }

        public virtual Articulo ArticuloNavigation { get; set; } = null!;
        public virtual Bodega BodegaNavigation { get; set; } = null!;
        public virtual CentroCosto? CentroCostoNavigation { get; set; }
        public virtual CuentaContable? CuentaContableNavigation { get; set; }
        public virtual Localizacion? LocalizacionNavigation { get; set; }
        public virtual Lote? LoteNavigation { get; set; }
        public virtual Pedido PedidoNavigation { get; set; } = null!;
        public virtual TipoDescuento? TipoDescuentoLineaNavigation { get; set; }
        public virtual UnidadDeMedidum? UnidadDistribucioNavigation { get; set; }
    }
}
