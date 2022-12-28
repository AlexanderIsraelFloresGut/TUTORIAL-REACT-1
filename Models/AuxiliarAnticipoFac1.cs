using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class AuxiliarAnticipoFac1
    {
        public string Factura { get; set; } = null!;
        public string TipoFac { get; set; } = null!;
        public string DocumentoCc { get; set; } = null!;
        public string TipoDocCc { get; set; } = null!;
        public decimal? MontoDocumento { get; set; }
        public decimal? MontoImpuesto1 { get; set; }
        public decimal? MontoImpuesto2 { get; set; }
        public decimal? MontoAplicado { get; set; }
        public decimal? MontoPendiente { get; set; }
        public decimal? AplicadoImpuesto1 { get; set; }
        public decimal? AplicadoImpuesto2 { get; set; }
        public decimal? SaldoImpuesto1 { get; set; }
        public decimal? SaldoImpuesto2 { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
    }
}
