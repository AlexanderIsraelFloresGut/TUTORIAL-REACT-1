using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class DetalleRetencionCo1
    {
        public string Proveedor { get; set; } = null!;
        public string Documento { get; set; } = null!;
        public string TipoDocumento { get; set; } = null!;
        public string CodigoRetencion { get; set; } = null!;
        public decimal Monto { get; set; }
        public decimal Base { get; set; }
        public string Autoretenedora { get; set; } = null!;
        public string CalculaProveedor { get; set; } = null!;
        public DateTime? FechaDocumento { get; set; }
        public string? Consecutivo { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
        public DateTime? FechaRige { get; set; }
        public DateTime? FechaContable { get; set; }
        public string? ClaseDocEs { get; set; }
        public string? Resolucion { get; set; }
        public string? Serie { get; set; }
        public string? ControlInterno { get; set; }
        public string? SerieNumero { get; set; }

        public virtual Retencione1 CodigoRetencionNavigation { get; set; } = null!;
    }
}
