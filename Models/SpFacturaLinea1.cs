using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class SpFacturaLinea1
    {
        public string Factura { get; set; } = null!;
        public string TipoDocumento { get; set; } = null!;
        public short Linea { get; set; }
        public string Bodega { get; set; } = null!;
        public decimal CostoTotalDolar { get; set; }
        public string? Pedido { get; set; }
        public string Articulo { get; set; } = null!;
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
        public string? Comentario { get; set; }
        public decimal CostoTotalLocal { get; set; }
        public short? PedidoLinea { get; set; }
        public string? DocumentoOrigen { get; set; }
        public decimal CostoEstimLocal { get; set; }
        public decimal CostoEstimDolar { get; set; }
        public decimal MontoRetencion { get; set; }
        public decimal? BaseImpuesto1 { get; set; }
        public decimal? BaseImpuesto2 { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
    }
}
