using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class SpOrdenCompra2
    {
        public string OrdenCompra { get; set; } = null!;
        public string? Usuario { get; set; }
        public string Proveedor { get; set; } = null!;
        public string Bodega { get; set; } = null!;
        public string CondicionPago { get; set; } = null!;
        public DateTime Fecha { get; set; }
        public DateTime? FechaCotizacion { get; set; }
        public DateTime? FechaOfrecida { get; set; }
        public DateTime? FechaEmision { get; set; }
        public DateTime? FechaReqEmbarque { get; set; }
        public DateTime FechaRequerida { get; set; }
        public decimal? MontoDescuento { get; set; }
        public decimal TotalMercaderia { get; set; }
        public decimal TotalImpuesto1 { get; set; }
        public decimal TotalImpuesto2 { get; set; }
        public decimal TotalAComprar { get; set; }
        public string Prioridad { get; set; } = null!;
        public string Estado { get; set; } = null!;
        public DateTime FechaHora { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
    }
}
