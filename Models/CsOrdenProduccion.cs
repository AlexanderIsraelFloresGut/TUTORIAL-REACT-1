using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class CsOrdenProduccion
    {
        public string OrdenProduccion { get; set; } = null!;
        public string Articulo { get; set; } = null!;
        public decimal Cantidad { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public DateTime? FechaLiberacion { get; set; }
        public string? TransAplicada { get; set; }
        public DateTime? FechaAplicacion { get; set; }
        public string Estado { get; set; } = null!;
        public decimal? CostoEstimadoLoc { get; set; }
        public decimal? CostoEstimadoDol { get; set; }
        public decimal? CantidadProducida { get; set; }
        public decimal? CostoRealLoc { get; set; }
        public decimal? CostoRealDol { get; set; }
        public string? Segmento { get; set; }
        public bool Consolidado { get; set; }
        public DateTime? FechaRequerida { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual Articulo ArticuloNavigation { get; set; } = null!;
    }
}
