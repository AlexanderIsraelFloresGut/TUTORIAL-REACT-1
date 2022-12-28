using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class ConceptoLiquidac2
    {
        public ConceptoLiquidac2()
        {
            EmpConcLiquidac2s = new HashSet<EmpConcLiquidac2>();
            LiquidacionAporte2s = new HashSet<LiquidacionAporte2>();
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

        public virtual Concepto2 ConceptoNavigation { get; set; } = null!;
        public virtual CuentaBancarium2 CuentaBancariaNavigation { get; set; } = null!;
        public virtual Monedum2 MonedaNavigation { get; set; } = null!;
        public virtual Usuario2 UsuarioNavigation { get; set; } = null!;
        public virtual ICollection<EmpConcLiquidac2> EmpConcLiquidac2s { get; set; }
        public virtual ICollection<LiquidacionAporte2> LiquidacionAporte2s { get; set; }
    }
}
