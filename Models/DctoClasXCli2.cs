using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class DctoClasXCli2
    {
        public string Cliente { get; set; } = null!;
        public string Clasificacion { get; set; } = null!;
        public int EscalaDcto { get; set; }
        public int VersionDcto { get; set; }
        public int? CantidadInicial { get; set; }
        public int? CantidadFinal { get; set; }
        public DateTime? FechaInicial { get; set; }
        public DateTime? FechaFinal { get; set; }
        public decimal PorcDescuento { get; set; }
        public string TipoDescuento { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
    }
}
