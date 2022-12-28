using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class TemporalesFacturaPrecio
    {
        public string? OrdenProduccion { get; set; }
        public string? Cliente { get; set; }
        public string? Empaque { get; set; }
        public string? FechaLiberar { get; set; }
        public string? Moneda { get; set; }
        public string? Articulo { get; set; }
        public decimal? TotalArticulo { get; set; }
        public string? Precio { get; set; }
        public decimal? TotalPagarArticulo { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
    }
}
