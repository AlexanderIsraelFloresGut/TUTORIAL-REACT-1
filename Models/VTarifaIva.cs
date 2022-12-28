using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class VTarifaIva
    {
        public string TipoImpuesto { get; set; } = null!;
        public string? DescripcionImpuesto { get; set; }
        public string? TipoTarifa { get; set; }
        public string? DescripcionTarifa { get; set; }
        public decimal? Porcentaje { get; set; }
        public DateTime RecordDate { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public Guid RowPointer { get; set; }
    }
}
