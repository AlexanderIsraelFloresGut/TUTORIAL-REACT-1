using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class SoftlandBiSaldo
    {
        public string? Centrocosto { get; set; }
        public string? Cuentacontable { get; set; }
        public DateTime Fecha { get; set; }
        public decimal? Debitofisclocal { get; set; }
        public decimal? Debitofiscdolar { get; set; }
        public decimal? Creditofisclocal { get; set; }
        public decimal? Creditofiscdolar { get; set; }
        public decimal? Saldofisclocal { get; set; }
        public decimal? Saldofiscdolar { get; set; }
        public decimal? Debitocorplocal { get; set; }
        public decimal? Debitocorpdolar { get; set; }
        public decimal? Creditocorplocal { get; set; }
        public decimal? Creditocorpdolar { get; set; }
        public decimal? Saldocorplocal { get; set; }
        public decimal? Saldocorpdolar { get; set; }
    }
}
