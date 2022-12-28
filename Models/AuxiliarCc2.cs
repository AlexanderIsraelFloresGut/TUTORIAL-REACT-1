using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class AuxiliarCc2
    {
        public string TipoCredito { get; set; } = null!;
        public string TipoDebito { get; set; } = null!;
        public DateTime Fecha { get; set; }
        public string Credito { get; set; } = null!;
        public string Debito { get; set; } = null!;
        public decimal MontoDebito { get; set; }
        public decimal MontoCredito { get; set; }
        public decimal MontoLocal { get; set; }
        public decimal MontoDolar { get; set; }
        public decimal MontoCliCredito { get; set; }
        public string? Asiento { get; set; }
        public string? TipoDocppago { get; set; }
        public string? DocumentoDocppago { get; set; }
        public decimal MontoCliDebito { get; set; }
        public string MonedaCredito { get; set; } = null!;
        public string MonedaDebito { get; set; } = null!;
        public string CliReporteCredit { get; set; } = null!;
        public string CliReporteDebito { get; set; } = null!;
        public string CliDocCredit { get; set; } = null!;
        public string CliDocDebito { get; set; } = null!;
        public string? TipoDocintcte { get; set; }
        public string? DocDocintcte { get; set; }
        public string? FoliosatDebito { get; set; }
        public string? FoliosatCredito { get; set; }
        public decimal? TipoCambioAplica { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
        public string? AsientoDifCambMr { get; set; }
        public string EsIntCorriente { get; set; } = null!;
        public string? DocAsocPerce { get; set; }

        public virtual Cliente2 CliDocCreditNavigation { get; set; } = null!;
        public virtual Cliente2 CliDocDebitoNavigation { get; set; } = null!;
        public virtual Cliente2 CliReporteCreditNavigation { get; set; } = null!;
        public virtual Cliente2 CliReporteDebitoNavigation { get; set; } = null!;
        public virtual DocumentosCc2 DocumentosCc2 { get; set; } = null!;
        public virtual DocumentosCc2 DocumentosCc2Navigation { get; set; } = null!;
        public virtual Monedum2 MonedaCreditoNavigation { get; set; } = null!;
        public virtual Monedum2 MonedaDebitoNavigation { get; set; } = null!;
    }
}
