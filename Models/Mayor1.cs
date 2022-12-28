using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class Mayor1
    {
        public string Asiento { get; set; } = null!;
        public int Consecutivo { get; set; }
        public string? Nit { get; set; }
        public string CentroCosto { get; set; } = null!;
        public string CuentaContable { get; set; } = null!;
        public DateTime Fecha { get; set; }
        public string TipoAsiento { get; set; } = null!;
        public string Fuente { get; set; } = null!;
        public string Referencia { get; set; } = null!;
        public string Origen { get; set; } = null!;
        public decimal? DebitoLocal { get; set; }
        public decimal? CreditoLocal { get; set; }
        public decimal? DebitoDolar { get; set; }
        public decimal? CreditoDolar { get; set; }
        public string Contabilidad { get; set; } = null!;
        public string ClaseAsiento { get; set; } = null!;
        public string EstadoConsFisc { get; set; } = null!;
        public string? AsntConsFisc { get; set; }
        public string EstadoConsCorp { get; set; } = null!;
        public string? AsntConsCorp { get; set; }
        public decimal? DebitoUnidades { get; set; }
        public decimal? CreditoUnidades { get; set; }
        public decimal? TipoCambio { get; set; }
        public decimal? BaseLocal { get; set; }
        public decimal? BaseDolar { get; set; }
        public string? Proyecto { get; set; }
        public string? Fase { get; set; }
        public string? DocumentoGlobal { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual AsientoMayorizado1 AsientoNavigation { get; set; } = null!;
        public virtual CentroCuentum1 C { get; set; } = null!;
        public virtual Nit1? NitNavigation { get; set; }
        public virtual TipoAsiento1 TipoAsientoNavigation { get; set; } = null!;
    }
}
