using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class IngresosLote1
    {
        public string Articulo { get; set; } = null!;
        public string Lote { get; set; } = null!;
        public int SecuenciaLote { get; set; }
        public DateTime? FechaEntrada { get; set; }
        public decimal? CantidadIngresada { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual Lote1 Lote1 { get; set; } = null!;
    }
}
