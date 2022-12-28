using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class OrdenCompraLinea
    {
        public OrdenCompraLinea()
        {
            DevolLinEmbarques = new HashSet<DevolLinEmbarque>();
            EmbarqueLineas = new HashSet<EmbarqueLinea>();
            SolicitudOrdenCos = new HashSet<SolicitudOrdenCo>();
        }

        public string OrdenCompra { get; set; } = null!;
        public short OrdenCompraLinea1 { get; set; }
        public string Articulo { get; set; } = null!;
        public string Bodega { get; set; } = null!;
        public short LineaUsuario { get; set; }
        public string? Descripcion { get; set; }
        public decimal CantidadOrdenada { get; set; }
        public decimal CantidadEmbarcada { get; set; }
        public decimal CantidadRecibida { get; set; }
        public decimal CantidadRechazada { get; set; }
        public decimal PrecioUnitario { get; set; }
        public decimal Impuesto1 { get; set; }
        public decimal Impuesto2 { get; set; }
        public string TipoDescuento { get; set; } = null!;
        public decimal PorcDescuento { get; set; }
        public decimal MontoDescuento { get; set; }
        public DateTime Fecha { get; set; }
        public string Estado { get; set; } = null!;
        public string? Comentario { get; set; }
        public decimal? FactorConversion { get; set; }
        public DateTime FechaRequerida { get; set; }
        public DateTime? FecEmbarqueProv { get; set; }
        public short? DiasParaEntrega { get; set; }
        public string? Factura { get; set; }
        public string? UnidadDistribucio { get; set; }
        public string? UsuarioCancela { get; set; }
        public DateTime? FechaHoraCancela { get; set; }
        public DateTime? FechaHoraCierre { get; set; }
        public string? UsuarioCierre { get; set; }
        public string? CentroCosto { get; set; }
        public string? CuentaContable { get; set; }
        public string? EMail { get; set; }
        public decimal? CantidadAceptada { get; set; }
        public string? Localizacion { get; set; }
        public string? Lote { get; set; }
        public string? Imp2PorCantidad { get; set; }
        public string? Fase { get; set; }
        public string? Proyecto { get; set; }
        public int? SerieCadena { get; set; }
        public string Imp1AfectaCosto { get; set; } = null!;
        public decimal? Imp1AsumidoDesc { get; set; }
        public decimal? Imp1AsumidoNodesc { get; set; }
        public decimal? Imp1RetenidoDesc { get; set; }
        public decimal? Imp1RetenidoNodesc { get; set; }
        public int? OrdenCambio { get; set; }
        public decimal PrecioArtProv { get; set; }
        public string? ConceptoMe { get; set; }
        public decimal? MontoAplicado { get; set; }
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
        public string EsCanastaBasica { get; set; } = null!;
        public decimal? MontoTotalImpuestoAcreditar { get; set; }
        public decimal? MontoTotalDeGastoAplicable { get; set; }
        public decimal? MontoProporcionalidad { get; set; }
        public decimal? SubtotalBienes { get; set; }
        public decimal? SubtotalServicios { get; set; }

        public virtual Articulo ArticuloNavigation { get; set; } = null!;
        public virtual Bodega BodegaNavigation { get; set; } = null!;
        public virtual CentroCuentum? C { get; set; }
        public virtual Localizacion? LocalizacionNavigation { get; set; }
        public virtual Lote? LoteNavigation { get; set; }
        public virtual OrdenCompra OrdenCompraNavigation { get; set; } = null!;
        public virtual UnidadDeMedidum? UnidadDistribucioNavigation { get; set; }
        public virtual Usuario2? UsuarioCancelaNavigation { get; set; }
        public virtual Usuario2? UsuarioCierreNavigation { get; set; }
        public virtual ICollection<DevolLinEmbarque> DevolLinEmbarques { get; set; }
        public virtual ICollection<EmbarqueLinea> EmbarqueLineas { get; set; }
        public virtual ICollection<SolicitudOrdenCo> SolicitudOrdenCos { get; set; }
    }
}
