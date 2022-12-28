using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class DocProveedorDm
    {
        public string DocumentoInv { get; set; } = null!;
        public string? Proveedor { get; set; }
        public string? CpCarnada { get; set; }
        public string? CpHielo { get; set; }
        public string? DocCp { get; set; }
        public string? DocCpHielo { get; set; }
        public string? DocCpCarnada { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
    }
}
