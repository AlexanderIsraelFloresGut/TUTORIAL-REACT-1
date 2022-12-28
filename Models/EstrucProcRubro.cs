using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class EstrucProcRubro
    {
        public string Articulo { get; set; } = null!;
        public string Version { get; set; } = null!;
        public string Operacion { get; set; } = null!;
        public string Rubro { get; set; } = null!;
        public decimal? CantidadEstandar { get; set; }
        public decimal CostoUnitEstand { get; set; }
        public decimal? CostoUnitDolar { get; set; }
        public string? Notas { get; set; }
        public decimal FactorConversion { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual EstrucProceso EstrucProceso { get; set; } = null!;
        public virtual RubroLiq RubroNavigation { get; set; } = null!;
    }
}
