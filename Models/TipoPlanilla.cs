using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class TipoPlanilla
    {
        public string Codigo { get; set; } = null!;
        public string? Descripcion { get; set; }
        public string? TipoAfiliado { get; set; }
        public string? PeriodoPlanilla { get; set; }
        public string? Departamento { get; set; }
        public string? ActEconomica { get; set; }
        public string? ClasePlanilla { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
    }
}
