using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class Conciliacion2
    {
        public Conciliacion2()
        {
            MovBanco2CNavigations = new HashSet<MovBanco2>();
            MovBanco2Cs = new HashSet<MovBanco2>();
            MovReportado2s = new HashSet<MovReportado2>();
        }

        public string CuentaBanco { get; set; } = null!;
        public int Conciliacion { get; set; }
        public DateTime FechaInicial { get; set; }
        public DateTime FechaFinal { get; set; }
        public decimal? SaldoLibros { get; set; }
        public decimal? SaldoBancos { get; set; }
        public decimal? CreditosTransito { get; set; }
        public decimal? DebitosTransito { get; set; }
        public decimal? CreditosConcil { get; set; }
        public decimal? DebitosConcil { get; set; }
        public decimal? CreditosSinDif { get; set; }
        public decimal? DebitosSinDif { get; set; }
        public decimal? CreditosConAjust { get; set; }
        public decimal? DebitosConAjust { get; set; }
        public decimal? CreditosAjustes { get; set; }
        public decimal? DebitosAjustes { get; set; }
        public decimal? CreditosLiquidar { get; set; }
        public decimal? DebitosLiquidar { get; set; }
        public decimal? CreditosAclarar { get; set; }
        public decimal? DebitosAclarar { get; set; }
        public decimal? CreditosAclaraEf { get; set; }
        public decimal? DebitosAclaraEf { get; set; }
        public decimal? CreditosAclaraCb { get; set; }
        public decimal? DebitosAclaraCb { get; set; }
        public string Estado { get; set; } = null!;
        public string? Notas { get; set; }
        public DateTime FchHoraCreacion { get; set; }
        public string UsuarioCreacion { get; set; } = null!;
        public DateTime? FchHoraModific { get; set; }
        public string? UsuarioModific { get; set; }
        public DateTime? FchHoraAprobac { get; set; }
        public string? UsuarioAprobac { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual CuentaBancarium2 CuentaBancoNavigation { get; set; } = null!;
        public virtual Usuario2? UsuarioAprobacNavigation { get; set; }
        public virtual Usuario2 UsuarioCreacionNavigation { get; set; } = null!;
        public virtual Usuario2? UsuarioModificNavigation { get; set; }
        public virtual ICollection<MovBanco2> MovBanco2CNavigations { get; set; }
        public virtual ICollection<MovBanco2> MovBanco2Cs { get; set; }
        public virtual ICollection<MovReportado2> MovReportado2s { get; set; }
    }
}
