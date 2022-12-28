using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class ConceptoLiquidac
    {
        public ConceptoLiquidac()
        {
            EmpConcLiquidacs = new HashSet<EmpConcLiquidac>();
            LiquidacionAportes = new HashSet<LiquidacionAporte>();
        }

        public string Concepto { get; set; } = null!;
        public string Moneda { get; set; } = null!;
        public DateTime FechaLiquidac { get; set; }
        public string Usuario { get; set; } = null!;
        public string DocsPorGenerar { get; set; } = null!;
        public string? Notas { get; set; }
        public string CuentaBancaria { get; set; } = null!;
        public DateTime PdoFinal { get; set; }
        public short NumeroLiquidac { get; set; }
        public string DocsPorImprimir { get; set; } = null!;
        public DateTime FechaHora { get; set; }
        public short? SubtipodocCheque { get; set; }
        public short? SubtipodocTef { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual Concepto ConceptoNavigation { get; set; } = null!;
        public virtual CuentaBancarium CuentaBancariaNavigation { get; set; } = null!;
        public virtual Monedum MonedaNavigation { get; set; } = null!;
        public virtual Usuario2 UsuarioNavigation { get; set; } = null!;
        public virtual ICollection<EmpConcLiquidac> EmpConcLiquidacs { get; set; }
        public virtual ICollection<LiquidacionAporte> LiquidacionAportes { get; set; }
    }
}
