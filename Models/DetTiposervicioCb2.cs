using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class DetTiposervicioCb2
    {
        public string CuentaBanco { get; set; } = null!;
        public string TipoDocumento { get; set; } = null!;
        public decimal Numero { get; set; }
        public string TipoServicio { get; set; } = null!;
        public int Consecutivo { get; set; }
        public string? Proyecto { get; set; }
        public string? Fase { get; set; }
        public decimal? MontoLocal { get; set; }
        public decimal? MontoDolar { get; set; }
        public decimal? MontoBanco { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual MovBanco2 MovBanco2 { get; set; } = null!;
    }
}
