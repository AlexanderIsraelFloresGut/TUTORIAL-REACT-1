using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class RubroLiq1
    {
        public RubroLiq1()
        {
            CelulaRubro1s = new HashSet<CelulaRubro1>();
            CentroCostoRubro1s = new HashSet<CentroCostoRubro1>();
            CentroCuentaRubro1s = new HashSet<CentroCuentaRubro1>();
            CuentaRubroDesg1s = new HashSet<CuentaRubroDesg1>();
            EstrucProcRubro1s = new HashSet<EstrucProcRubro1>();
            LiqPcDesgContum1s = new HashSet<LiqPcDesgContum1>();
            LiqPcDesgRubro1s = new HashSet<LiqPcDesgRubro1>();
            OpOperDetMedic1s = new HashSet<OpOperDetMedic1>();
            OpOperacionRubro1s = new HashSet<OpOperacionRubro1>();
        }

        public string Rubro { get; set; } = null!;
        public string DescripRubro { get; set; } = null!;
        public string? TipoGasto { get; set; }
        public string? Unidad { get; set; }
        public string MedirAlReportar { get; set; } = null!;
        public short ParametroProrat { get; set; }
        public decimal? CostoPorUnidadL { get; set; }
        public decimal? CostoPorUnidadD { get; set; }
        public string AplicContCelulas { get; set; } = null!;
        public string UsuarioCreacion { get; set; } = null!;
        public DateTime FchHoraCreacion { get; set; }
        public string? UsuarioUltModif { get; set; }
        public DateTime? FchHoraUltModif { get; set; }
        public string? AsociacionContab { get; set; }
        public string? RubroLiquidacion { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual Unidad1? UnidadNavigation { get; set; }
        public virtual Usuario2 UsuarioCreacionNavigation { get; set; } = null!;
        public virtual Usuario2? UsuarioUltModifNavigation { get; set; }
        public virtual NotasRubro1 NotasRubro1 { get; set; } = null!;
        public virtual ICollection<CelulaRubro1> CelulaRubro1s { get; set; }
        public virtual ICollection<CentroCostoRubro1> CentroCostoRubro1s { get; set; }
        public virtual ICollection<CentroCuentaRubro1> CentroCuentaRubro1s { get; set; }
        public virtual ICollection<CuentaRubroDesg1> CuentaRubroDesg1s { get; set; }
        public virtual ICollection<EstrucProcRubro1> EstrucProcRubro1s { get; set; }
        public virtual ICollection<LiqPcDesgContum1> LiqPcDesgContum1s { get; set; }
        public virtual ICollection<LiqPcDesgRubro1> LiqPcDesgRubro1s { get; set; }
        public virtual ICollection<OpOperDetMedic1> OpOperDetMedic1s { get; set; }
        public virtual ICollection<OpOperacionRubro1> OpOperacionRubro1s { get; set; }
    }
}
