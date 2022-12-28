using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class DetallePreasiento2
    {
        public string Asiento { get; set; } = null!;
        public int Consecutivo { get; set; }
        public string? Nit { get; set; }
        public string CentroCosto { get; set; } = null!;
        public string CuentaContable { get; set; } = null!;
        public string Fuente { get; set; } = null!;
        public string Referencia { get; set; } = null!;
        public decimal? DebitoLocal { get; set; }
        public decimal? DebitoDolar { get; set; }
        public decimal? CreditoLocal { get; set; }
        public decimal? CreditoDolar { get; set; }
        public decimal? DebitoUnidades { get; set; }
        public decimal? CreditoUnidades { get; set; }
        public decimal? TipoCambio { get; set; }
        public decimal? BaseLocal { get; set; }
        public decimal? BaseDolar { get; set; }
        public string? Proyecto { get; set; }
        public string? Fase { get; set; }
        public string Proceso { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual Preasiento2 AsientoNavigation { get; set; } = null!;
    }
}
