using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class SpOrdenCompraLinea1
    {
        public string OrdenCompra { get; set; } = null!;
        public short OrdenCompraLinea { get; set; }
        public string Articulo { get; set; } = null!;
        public string Bodega { get; set; } = null!;
        public string? Descripcion { get; set; }
        public decimal CantidadOrdenada { get; set; }
        public decimal CantidadEmbarcada { get; set; }
        public decimal CantidadRecibida { get; set; }
        public decimal CantidadRechazada { get; set; }
        public decimal PrecioUnitario { get; set; }
        public decimal Impuesto1 { get; set; }
        public decimal Impuesto2 { get; set; }
        public decimal MontoDescuento { get; set; }
        public DateTime Fecha { get; set; }
        public string Estado { get; set; } = null!;
        public DateTime FechaRequerida { get; set; }
        public string? Factura { get; set; }
        public string? EMail { get; set; }
        public decimal PrecioArtProv { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
    }
}
