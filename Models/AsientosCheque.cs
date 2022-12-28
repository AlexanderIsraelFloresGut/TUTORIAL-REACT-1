using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class AsientosCheque
    {
        public int ChequeInterno { get; set; }
        public int Consecutivo { get; set; }
        public string CtrContable { get; set; } = null!;
        public string CtaContable { get; set; } = null!;
        public string TipoAsiento { get; set; } = null!;
        public DateTime Fecha { get; set; }
        public string Referencia { get; set; } = null!;
        public string Contabilidad { get; set; } = null!;
        public decimal? Debito { get; set; }
        public decimal? Credito { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual Cheque ChequeInternoNavigation { get; set; } = null!;
        public virtual CentroCuentum Ct { get; set; } = null!;
        public virtual TipoAsiento TipoAsientoNavigation { get; set; } = null!;
    }
}
