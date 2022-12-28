using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class EmbarqueLinea1
    {
        public EmbarqueLinea1()
        {
            DetLinEmbarque1s = new HashSet<DetLinEmbarque1>();
            DevolLinEmbarque1s = new HashSet<DevolLinEmbarque1>();
            LiquidacDetalle1s = new HashSet<LiquidacDetalle1>();
        }

        public string Embarque { get; set; } = null!;
        public short EmbarqueLinea { get; set; }
        public string? OrdenCompra { get; set; }
        public short? OrdenCompraLinea { get; set; }
        public string Articulo { get; set; } = null!;
        public string Bodega { get; set; } = null!;
        public decimal CantidadEmbarcada { get; set; }
        public decimal CantidadRecibida { get; set; }
        public decimal CantidadRechazada { get; set; }
        public decimal PrecioUnitario { get; set; }
        public decimal CostUnFiscLocal { get; set; }
        public decimal CostUnFiscDolar { get; set; }
        public decimal CostUnEstiLocal { get; set; }
        public decimal CostUnEstiDolar { get; set; }
        public decimal CostUnRealLocal { get; set; }
        public decimal CostUnRealDolar { get; set; }
        public short PlazoReabast { get; set; }
        public decimal PorcAjusteCosto { get; set; }
        public decimal ExistenciaTotIng { get; set; }
        public decimal? CantRecibidaUa { get; set; }
        public decimal? CantRechazadaUa { get; set; }
        public string? CodigoArancel { get; set; }
        public decimal? Subtotal { get; set; }
        public decimal? Descuento { get; set; }
        public decimal? Impuesto1 { get; set; }
        public decimal? Impuesto2 { get; set; }
        public decimal? Rubro1 { get; set; }
        public decimal? Rubro2 { get; set; }
        public string? Imp1Afectacosto { get; set; }
        public string? Imp2Afectacosto { get; set; }
        public string? Rubro1Afectacosto { get; set; }
        public string? Rubro2Afectacosto { get; set; }
        public string RecibidoDeMas { get; set; } = null!;
        public int? SerieCadena { get; set; }
        public decimal? CantidadDevuelta { get; set; }
        public decimal? CantDevueltaua { get; set; }
        public string? UnidadDistribucio { get; set; }
        public string? CentroCosto { get; set; }
        public string? CuentaContable { get; set; }
        public string? UnidadOperativa { get; set; }
        public int? Numero { get; set; }
        public int? LineaApartado { get; set; }
        public string? CambioPresup { get; set; }
        public DateTime? Secuencia { get; set; }
        public string? Proveedor { get; set; }
        public string? Documento { get; set; }
        public string? TipoDocumento { get; set; }
        public string MonedaOc { get; set; } = null!;
        public decimal? PrecioUnitOcLocal { get; set; }
        public decimal? PrecioUnitOcDolar { get; set; }
        public decimal? TcPrecioOcLocal { get; set; }
        public decimal? TcPrecioOcDolar { get; set; }
        public decimal? PrecioUnitDoc { get; set; }
        public decimal? TcPrecioDocLocal { get; set; }
        public decimal? TcPrecioDocDolar { get; set; }
        public decimal PorcDescUnitario { get; set; }
        public decimal MontoDescUnitario { get; set; }
        public decimal? DescuentoLinea { get; set; }
        public string? Fase { get; set; }
        public string? Proyecto { get; set; }
        public string? Pais { get; set; }
        public string? Tipo { get; set; }
        public decimal? BaseImpuesto1 { get; set; }
        public decimal? BaseImpuesto2 { get; set; }
        public int? OrdenCambio { get; set; }
        public decimal? Imp1AsumidoDesc { get; set; }
        public decimal? Imp1AsumidoNodesc { get; set; }
        public decimal? Imp1RetenidoDesc { get; set; }
        public decimal? Imp1RetenidoNodesc { get; set; }
        public string? ConceptoMe { get; set; }
        public decimal? CostUnCompLocal { get; set; }
        public decimal? CostUnCompDolar { get; set; }
        public decimal? CostUnEstiCompLocal { get; set; }
        public decimal? CostUnEstiCompDolar { get; set; }
        public decimal? CostUnRealCompLocal { get; set; }
        public decimal? CostUnRealCompDolar { get; set; }
        public decimal? MontoAplicadoOc { get; set; }
        public string? BackorderMonto { get; set; }
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
        public decimal? SubtotalBienesOc { get; set; }
        public decimal? SubtotalServiciosOc { get; set; }

        public virtual Articulo1 ArticuloNavigation { get; set; } = null!;
        public virtual Bodega1 BodegaNavigation { get; set; } = null!;
        public virtual CentroCuentum1? C { get; set; }
        public virtual DetDocumentoEmbarque1? DetDocumentoEmbarque1 { get; set; }
        public virtual Embarque1 EmbarqueNavigation { get; set; } = null!;
        public virtual Monedum1 MonedaOcNavigation { get; set; } = null!;
        public virtual OrdenCompraLinea1? OrdenCompraNavigation { get; set; }
        public virtual SerieCadena1? SerieCadenaNavigation { get; set; }
        public virtual UnidadDeMedidum1? UnidadDistribucioNavigation { get; set; }
        public virtual ICollection<DetLinEmbarque1> DetLinEmbarque1s { get; set; }
        public virtual ICollection<DevolLinEmbarque1> DevolLinEmbarque1s { get; set; }
        public virtual ICollection<LiquidacDetalle1> LiquidacDetalle1s { get; set; }
    }
}
