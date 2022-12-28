using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class DetTiposervicioCc1
    {
        public string Documento { get; set; } = null!;
        public string Tipo { get; set; } = null!;
        public string TipoServicio { get; set; } = null!;
        public int Consecutivo { get; set; }
        public string? Proyecto { get; set; }
        public string? Fase { get; set; }
        public decimal? MontoLocal { get; set; }
        public decimal? MontoDolar { get; set; }
        public decimal? MontoCliente { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual DocumentosCc1 DocumentosCc1 { get; set; } = null!;
    }
}
