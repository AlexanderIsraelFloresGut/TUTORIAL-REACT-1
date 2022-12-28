using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class OtArticulo
    {
        public int OrdenTrabajo { get; set; }
        public string Articulo { get; set; } = null!;
        public decimal CantidadEstimad { get; set; }
        public decimal CantidadAcumulada { get; set; }
        public decimal CantidadReservada { get; set; }
        public decimal CostoEstLocal { get; set; }
        public decimal CostoEstDolar { get; set; }
        public decimal CostoAcuLocal { get; set; }
        public decimal CostoAcuDolar { get; set; }
        public string AceptaMovimientos { get; set; } = null!;
        public decimal? CantidadPendAplicar { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual Articulo ArticuloNavigation { get; set; } = null!;
        public virtual OrdenTrabajo OrdenTrabajoNavigation { get; set; } = null!;
    }
}
