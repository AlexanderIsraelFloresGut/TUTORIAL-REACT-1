using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class CuentaDepreciacio1
    {
        public string TipoActivo { get; set; } = null!;
        public string CentroCosto { get; set; } = null!;
        public string CtaDeprNormal { get; set; } = null!;
        public string CtaDeprReval { get; set; } = null!;
        public string? Proyecto { get; set; }
        public string? Fase { get; set; }
        public string? CtaDeprNormalC { get; set; }
        public string? CtaDeprRevalC { get; set; }
        public string? CtaDeprAiF { get; set; }
        public string? CtaDeprAiC { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
        public string? CtaDeprDesmantelaF { get; set; }
        public string? CtaDeprDesmantelaC { get; set; }

        public virtual CentroCosto1 CentroCostoNavigation { get; set; } = null!;
        public virtual CuentaContable1? CtaDeprAiCNavigation { get; set; }
        public virtual CuentaContable1? CtaDeprAiFNavigation { get; set; }
        public virtual CuentaContable1? CtaDeprDesmantelaCNavigation { get; set; }
        public virtual CuentaContable1? CtaDeprDesmantelaFNavigation { get; set; }
        public virtual CuentaContable1? CtaDeprNormalCNavigation { get; set; }
        public virtual CuentaContable1 CtaDeprNormalNavigation { get; set; } = null!;
        public virtual CuentaContable1? CtaDeprRevalCNavigation { get; set; }
        public virtual CuentaContable1 CtaDeprRevalNavigation { get; set; } = null!;
        public virtual TipoActivo1 TipoActivoNavigation { get; set; } = null!;
    }
}
