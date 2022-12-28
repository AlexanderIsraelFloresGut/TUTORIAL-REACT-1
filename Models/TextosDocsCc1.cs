using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class TextosDocsCc1
    {
        public string Tipo { get; set; } = null!;
        public string Documento { get; set; } = null!;
        public string TextoId { get; set; } = null!;
        public string? Texto { get; set; }
        public string? RecibidoDe { get; set; }
        public decimal? MontoChk { get; set; }
        public decimal? MontoTef { get; set; }
        public decimal? MontoOtros { get; set; }
        public decimal? MontoEfectivo { get; set; }
        public string? DocChk { get; set; }
        public string? DocTef { get; set; }
        public string? DocOtros { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
        public decimal? MontoDep { get; set; }
        public decimal? MontoCer { get; set; }
        public decimal? MontoTar { get; set; }
        public string? DocDep { get; set; }
        public string? DocCer { get; set; }
        public string? DocTar { get; set; }

        public virtual DocumentosCc1 DocumentosCc1 { get; set; } = null!;
    }
}
