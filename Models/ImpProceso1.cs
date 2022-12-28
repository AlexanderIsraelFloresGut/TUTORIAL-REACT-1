using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class ImpProceso1
    {
        public short Linea { get; set; }
        public string? Articulo { get; set; }
        public short? Padre { get; set; }
        public decimal? CantRequerida { get; set; }
        public decimal? ExistenciaActual { get; set; }
        public decimal? PorcentajeUso { get; set; }
        public decimal? CapProduccion { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual Articulo1? ArticuloNavigation { get; set; }
    }
}
