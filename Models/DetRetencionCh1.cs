using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class DetRetencionCh1
    {
        public int Vale { get; set; }
        public int Linea { get; set; }
        public string CodigoRetencion { get; set; } = null!;
        public string? Retencion { get; set; }
        public decimal Monto { get; set; }
        public string Estado { get; set; } = null!;
        public string Pagada { get; set; } = null!;
        public decimal? Base { get; set; }
        public DateTime? FechaDocumento { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
        public DateTime? FechaRige { get; set; }
        public string? ClaseDocEs { get; set; }
        public string? Resolucion { get; set; }
        public string? Serie { get; set; }
        public string? ControlInterno { get; set; }
        public string? SerieNumero { get; set; }

        public virtual Retencione1 CodigoRetencionNavigation { get; set; } = null!;
        public virtual DocsSoporte1 DocsSoporte1 { get; set; } = null!;
    }
}
