using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class AperturaCaja
    {
        public string Caja { get; set; } = null!;
        public string Usuario { get; set; } = null!;
        public int NumApertura { get; set; }
        public DateTime? FchHoraApertura { get; set; }
        public DateTime? FchHoraCierre { get; set; }
        public string Estado { get; set; } = null!;
        public decimal SaldoInicialLoc { get; set; }
        public decimal SaldoFinalLoc { get; set; }
        public decimal SaldoReciboLoc { get; set; }
        public decimal SaldoInicialDol { get; set; }
        public decimal SaldoFinalDol { get; set; }
        public decimal SaldoReciboDol { get; set; }
        public string? Notas { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual Caja CajaNavigation { get; set; } = null!;
        public virtual Usuario2 UsuarioNavigation { get; set; } = null!;
    }
}
