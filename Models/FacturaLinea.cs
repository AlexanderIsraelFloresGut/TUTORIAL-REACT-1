using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class FacturaLinea
    {
        public FacturaLinea()
        {
            DespachoDetalles = new HashSet<DespachoDetalle>();
            FacturaDocCcs = new HashSet<FacturaDocCc>();
        }

        public string Factura { get; set; } = null!;
        public string TipoDocumento { get; set; } = null!;
        public short Linea { get; set; }
        public string Bodega { get; set; } = null!;
        public decimal CostoTotalDolar { get; set; }
        public string? Pedido { get; set; }
        public string Articulo { get; set; } = null!;
        public string? Localizacion { get; set; }
        public string? Lote { get; set; }
        public string Anulada { get; set; } = null!;
        public DateTime FechaFactura { get; set; }
        public decimal Cantidad { get; set; }
        public decimal PrecioUnitario { get; set; }
        public decimal TotalImpuesto1 { get; set; }
        public decimal TotalImpuesto2 { get; set; }
        public decimal DescTotLinea { get; set; }
        public decimal DescTotGeneral { get; set; }
        public decimal CostoTotal { get; set; }
        public decimal PrecioTotal { get; set; }
        public string? Descripcion { get; set; }
        public string? Comentario { get; set; }
        public decimal CantidadDevuelt { get; set; }
        public decimal DescuentoVolumen { get; set; }
        public string TipoLinea { get; set; } = null!;
        public decimal CantidadAceptada { get; set; }
        public decimal CantNoEntregada { get; set; }
        public decimal CostoTotalLocal { get; set; }
        public short? PedidoLinea { get; set; }
        public short MultiplicadorEv { get; set; }
        public int? SerieCadena { get; set; }
        public int? SerieCadNoAcept { get; set; }
        public int? SerieCadAceptada { get; set; }
        public string? DocumentoOrigen { get; set; }
        public short? LineaOrigen { get; set; }
        public string? TipoOrigen { get; set; }
        public string? UnidadDistribucio { get; set; }
        public decimal CantDespachada { get; set; }
        public decimal CostoEstimLocal { get; set; }
        public decimal CostoEstimDolar { get; set; }
        public decimal? CantAnulPordespa { get; set; }
        public decimal MontoRetencion { get; set; }
        public decimal? BaseImpuesto1 { get; set; }
        public decimal? BaseImpuesto2 { get; set; }
        public string? Proyecto { get; set; }
        public string? Fase { get; set; }
        public string? CentroCosto { get; set; }
        public string? CuentaContable { get; set; }
        public decimal CostoTotalComp { get; set; }
        public decimal CostoTotalCompLocal { get; set; }
        public decimal CostoTotalCompDolar { get; set; }
        public decimal CostoEstimCompLocal { get; set; }
        public decimal CostoEstimCompDolar { get; set; }
        public decimal CantDevProceso { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
        public string? TipoImpuesto1 { get; set; }
        public string? TipoTarifa1 { get; set; }
        public string? TipoImpuesto2 { get; set; }
        public string? TipoTarifa2 { get; set; }
        public decimal? PorcExoneracion { get; set; }
        public decimal? MontoExoneracion { get; set; }
        public string? EsOtroCargo { get; set; }
        public string? EsCanastaBasica { get; set; }
        public string? EsServicioMedico { get; set; }
        public decimal? MontoDevueltoIva { get; set; }
        public decimal? PorcExoneracion2 { get; set; }
        public decimal? MontoExoneracion2 { get; set; }
        public string? TipoDescuentoLinea { get; set; }

        public virtual Articulo ArticuloNavigation { get; set; } = null!;
        public virtual Bodega BodegaNavigation { get; set; } = null!;
        public virtual CentroCosto? CentroCostoNavigation { get; set; }
        public virtual CuentaContable? CuentaContableNavigation { get; set; }
        public virtual Factura FacturaNavigation { get; set; } = null!;
        public virtual Localizacion? LocalizacionNavigation { get; set; }
        public virtual Lote? LoteNavigation { get; set; }
        public virtual SerieCadena? SerieCadAceptadaNavigation { get; set; }
        public virtual SerieCadena? SerieCadNoAceptNavigation { get; set; }
        public virtual SerieCadena? SerieCadenaNavigation { get; set; }
        public virtual TipoDescuento? TipoDescuentoLineaNavigation { get; set; }
        public virtual UnidadDeMedidum? UnidadDistribucioNavigation { get; set; }
        public virtual ICollection<DespachoDetalle> DespachoDetalles { get; set; }
        public virtual ICollection<FacturaDocCc> FacturaDocCcs { get; set; }
    }
}
