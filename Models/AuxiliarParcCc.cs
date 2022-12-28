using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class AuxiliarParcCc
    {
        public string TipoCredito { get; set; } = null!;
        public string TipoDebito { get; set; } = null!;
        public DateTime Fecha { get; set; }
        public string Credito { get; set; } = null!;
        public string Debito { get; set; } = null!;
        public short Parcialidad { get; set; }
        public decimal MontoDebito { get; set; }
        public decimal MontoCredito { get; set; }
        public decimal MontoLocal { get; set; }
        public decimal MontoDolar { get; set; }
        public decimal MontoCliCredito { get; set; }
        public decimal MontoCliDebito { get; set; }
        public string? Asiento { get; set; }
        public decimal? MontoAmortiza { get; set; }
        public decimal? MontoAmortizaLoc { get; set; }
        public decimal? MontoAmortizaDol { get; set; }
        public decimal? MontoInteres { get; set; }
        public decimal? MontoInteresLoc { get; set; }
        public decimal? MontoInteresDol { get; set; }
        public decimal? MontoCuota { get; set; }
        public decimal? MontoCuotaLoc { get; set; }
        public decimal? MontoCuotaDol { get; set; }
        public decimal? TipoCambioAplica { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
    }
}
