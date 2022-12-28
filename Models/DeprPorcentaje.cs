using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class DeprPorcentaje
    {
        public string ActivoFijo { get; set; } = null!;
        public string Mejora { get; set; } = null!;
        public short Periodo { get; set; }
        public string Contabilidad { get; set; } = null!;
        public decimal Porcentaje { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
        public string? Desmantelamiento { get; set; }

        public virtual ActivoMejora ActivoMejora { get; set; } = null!;
    }
}
