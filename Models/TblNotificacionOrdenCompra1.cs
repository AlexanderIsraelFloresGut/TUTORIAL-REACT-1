using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class TblNotificacionOrdenCompra1
    {
        public string? OrdenCompra { get; set; }
        public string? Proveedor { get; set; }
        public string? Bodega { get; set; }
        public string? Moneda { get; set; }
        public DateTime? Fecha { get; set; }
        public decimal? TotalMercaderia { get; set; }
        public string? Prioridad { get; set; }
        public DateTime? FechaHoraGrabacion { get; set; }
        public string Estado { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
    }
}
