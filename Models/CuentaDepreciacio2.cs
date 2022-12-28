using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class CuentaDepreciacio2
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

        public virtual CentroCosto2 CentroCostoNavigation { get; set; } = null!;
        public virtual CuentaContable2? CtaDeprAiCNavigation { get; set; }
        public virtual CuentaContable2? CtaDeprAiFNavigation { get; set; }
        public virtual CuentaContable2? CtaDeprDesmantelaCNavigation { get; set; }
        public virtual CuentaContable2? CtaDeprDesmantelaFNavigation { get; set; }
        public virtual CuentaContable2? CtaDeprNormalCNavigation { get; set; }
        public virtual CuentaContable2 CtaDeprNormalNavigation { get; set; } = null!;
        public virtual CuentaContable2? CtaDeprRevalCNavigation { get; set; }
        public virtual CuentaContable2 CtaDeprRevalNavigation { get; set; } = null!;
        public virtual TipoActivo2 TipoActivoNavigation { get; set; } = null!;
    }
}
