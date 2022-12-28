using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class SaldoNit1
    {
        public string CentroCosto { get; set; } = null!;
        public string CuentaContable { get; set; } = null!;
        public string Nit { get; set; } = null!;
        public DateTime Fecha { get; set; }
        public decimal SaldoFiscLocal { get; set; }
        public decimal SaldoFiscDolar { get; set; }
        public decimal SaldoCorpLocal { get; set; }
        public decimal SaldoCorpDolar { get; set; }
        public decimal DebitoFiscLocal { get; set; }
        public decimal CreditoFiscLocal { get; set; }
        public decimal DebitoCorpLocal { get; set; }
        public decimal CreditoCorpLocal { get; set; }
        public decimal DebitoFiscDolar { get; set; }
        public decimal CreditoFiscDolar { get; set; }
        public decimal DebitoCorpDolar { get; set; }
        public decimal CreditoCorpDolar { get; set; }
        public decimal SaldoFiscUnd { get; set; }
        public decimal SaldoCorpUnd { get; set; }
        public decimal DebitoFiscUnd { get; set; }
        public decimal CreditoFiscUnd { get; set; }
        public decimal DebitoCorpUnd { get; set; }
        public decimal CreditoCorpUnd { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual CentroCuentum1 C { get; set; } = null!;
    }
}
