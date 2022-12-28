using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class TempHistReval1
    {
        public string Usuario { get; set; } = null!;
        public int Consecutivo { get; set; }
        public string ActivoFijo { get; set; } = null!;
        public string Mejora { get; set; } = null!;
        public string TipoActivo { get; set; } = null!;
        public string Metodo { get; set; } = null!;
        public decimal RevalValor { get; set; }
        public decimal RevalValorC { get; set; }
        public decimal RevalDeprAcumF { get; set; }
        public decimal RevalDeprAcumC { get; set; }
        public string MetodoC { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
    }
}
