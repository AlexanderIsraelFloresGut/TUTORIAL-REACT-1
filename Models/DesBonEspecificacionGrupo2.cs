using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class DesBonEspecificacionGrupo2
    {
        public int Escala { get; set; }
        public string Regla { get; set; } = null!;
        public string? Articulo { get; set; }
        public decimal CantidadMinima { get; set; }
        public decimal CantidadMaxima { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual DesBonRegla2 ReglaNavigation { get; set; } = null!;
    }
}
