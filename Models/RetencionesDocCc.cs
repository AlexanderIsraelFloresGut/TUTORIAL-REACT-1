using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class RetencionesDocCc
    {
        public string Tipo { get; set; } = null!;
        public string Documento { get; set; } = null!;
        public string CodigoRetencion { get; set; } = null!;
        public string? Retencion { get; set; }
        public string DocReferencia { get; set; } = null!;
        public decimal Monto { get; set; }
        public string Estado { get; set; } = null!;
        public decimal? Base { get; set; }
        public string? Autoretenedora { get; set; }
        public string? Asiento { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
        public DateTime? FechaDocumento { get; set; }
        public DateTime? FechaRige { get; set; }
        public DateTime? FechaContable { get; set; }
        public string? TipoApliCancelar { get; set; }
        public decimal? SaldoCancelar { get; set; }

        public virtual Retencione CodigoRetencionNavigation { get; set; } = null!;
        public virtual DocumentosCc DocumentosCc { get; set; } = null!;
    }
}
