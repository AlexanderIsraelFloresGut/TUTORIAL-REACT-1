using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class CpDetRetencionPar1
    {
        public string Tipo { get; set; } = null!;
        public string Proveedor { get; set; } = null!;
        public string Documento { get; set; } = null!;
        public string Retencion { get; set; } = null!;
        public string NumReten { get; set; } = null!;
        public decimal? Monto { get; set; }
        public string? TipoCan { get; set; }
        public string? ProveeCan { get; set; }
        public string? DocCan { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual DetalleRetencion1 DetalleRetencion1 { get; set; } = null!;
        public virtual DocumentosCp1? DocumentosCp1 { get; set; }
    }
}
