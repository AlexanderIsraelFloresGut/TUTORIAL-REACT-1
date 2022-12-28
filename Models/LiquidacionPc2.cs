using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class LiquidacionPc2
    {
        public LiquidacionPc2()
        {
            LiqPcDesgContum2s = new HashSet<LiqPcDesgContum2>();
            LiqPcDesgRubro2s = new HashSet<LiqPcDesgRubro2>();
            OpOperContLiq2s = new HashSet<OpOperContLiq2>();
            OpOperCostAux2s = new HashSet<OpOperCostAux2>();
        }

        public string Liquidacion { get; set; } = null!;
        public string Estado { get; set; } = null!;
        public DateTime Periodo { get; set; }
        public string? Asiento { get; set; }
        public decimal CostMatAplicLoc { get; set; }
        public decimal? CostMatAplicDol { get; set; }
        public decimal CostMatContLoc { get; set; }
        public decimal? CostMatContDol { get; set; }
        public decimal CostMoAplicLoc { get; set; }
        public decimal? CostMoAplicDol { get; set; }
        public decimal CostMoContLoc { get; set; }
        public decimal? CostMoContDol { get; set; }
        public decimal CostGifAplicLoc { get; set; }
        public decimal? CostGifAplicDol { get; set; }
        public decimal CostGifContLoc { get; set; }
        public decimal? CostGifContDol { get; set; }
        public string UsuarioCreacion { get; set; } = null!;
        public DateTime FchHoraCreacion { get; set; }
        public string? UsuarioUltModif { get; set; }
        public DateTime? FchHoraUltModif { get; set; }
        public string? UsuarioCalculo { get; set; }
        public DateTime? FchHoraCalculo { get; set; }
        public string? UsuarioAprobacion { get; set; }
        public DateTime? FchHoraAprobac { get; set; }
        public string? UsuarioCancelac { get; set; }
        public DateTime? FchHoraCancelac { get; set; }
        public string? Notas { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual Usuario2? UsuarioAprobacionNavigation { get; set; }
        public virtual Usuario2? UsuarioCalculoNavigation { get; set; }
        public virtual Usuario2? UsuarioCancelacNavigation { get; set; }
        public virtual Usuario2 UsuarioCreacionNavigation { get; set; } = null!;
        public virtual Usuario2? UsuarioUltModifNavigation { get; set; }
        public virtual ICollection<LiqPcDesgContum2> LiqPcDesgContum2s { get; set; }
        public virtual ICollection<LiqPcDesgRubro2> LiqPcDesgRubro2s { get; set; }
        public virtual ICollection<OpOperContLiq2> OpOperContLiq2s { get; set; }
        public virtual ICollection<OpOperCostAux2> OpOperCostAux2s { get; set; }
    }
}
