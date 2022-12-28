using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class TempHistDepr2
    {
        public string Usuario { get; set; } = null!;
        public int Consecutivo { get; set; }
        public string ActivoFijo { get; set; } = null!;
        public string Mejora { get; set; } = null!;
        public string TipoActivo { get; set; } = null!;
        public string Contabilidad { get; set; } = null!;
        public string Metodo { get; set; } = null!;
        public decimal DeprLocal { get; set; }
        public decimal DeprDolar { get; set; }
        public decimal DeprRevLocal { get; set; }
        public decimal DeprRevDolar { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
    }
}
