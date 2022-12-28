using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class RubroLiq
    {
        public RubroLiq()
        {
            CelulaRubros = new HashSet<CelulaRubro>();
            CentroCostoRubros = new HashSet<CentroCostoRubro>();
            CentroCuentaRubros = new HashSet<CentroCuentaRubro>();
            CuentaRubroDesgs = new HashSet<CuentaRubroDesg>();
            EstrucProcRubros = new HashSet<EstrucProcRubro>();
            LiqPcDesgConta = new HashSet<LiqPcDesgContum>();
            LiqPcDesgRubros = new HashSet<LiqPcDesgRubro>();
            OpOperDetMedics = new HashSet<OpOperDetMedic>();
            OpOperacionRubros = new HashSet<OpOperacionRubro>();
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

        public virtual Unidad? UnidadNavigation { get; set; }
        public virtual Usuario2 UsuarioCreacionNavigation { get; set; } = null!;
        public virtual Usuario2? UsuarioUltModifNavigation { get; set; }
        public virtual NotasRubro NotasRubro { get; set; } = null!;
        public virtual ICollection<CelulaRubro> CelulaRubros { get; set; }
        public virtual ICollection<CentroCostoRubro> CentroCostoRubros { get; set; }
        public virtual ICollection<CentroCuentaRubro> CentroCuentaRubros { get; set; }
        public virtual ICollection<CuentaRubroDesg> CuentaRubroDesgs { get; set; }
        public virtual ICollection<EstrucProcRubro> EstrucProcRubros { get; set; }
        public virtual ICollection<LiqPcDesgContum> LiqPcDesgConta { get; set; }
        public virtual ICollection<LiqPcDesgRubro> LiqPcDesgRubros { get; set; }
        public virtual ICollection<OpOperDetMedic> OpOperDetMedics { get; set; }
        public virtual ICollection<OpOperacionRubro> OpOperacionRubros { get; set; }
    }
}
