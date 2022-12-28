using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class OpOperDetMedic2
    {
        public string OrdenProduccion { get; set; } = null!;
        public string Operacion { get; set; } = null!;
        public DateTime FechaHoraProduc { get; set; }
        public short SecuenciaMedic { get; set; }
        public string? Rubro { get; set; }
        public decimal CantidadMedic { get; set; }
        public string MedicionObligada { get; set; } = null!;
        public string? Notas { get; set; }
        public decimal? CostoRealLoc { get; set; }
        public decimal? CostoRealDol { get; set; }
        public decimal FactorConversion { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual OpOperDet2 OpOperDet2 { get; set; } = null!;
    }
}
