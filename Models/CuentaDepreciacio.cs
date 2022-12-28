using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class CuentaDepreciacio
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

        public virtual CentroCosto CentroCostoNavigation { get; set; } = null!;
        public virtual CuentaContable? CtaDeprAiCNavigation { get; set; }
        public virtual CuentaContable? CtaDeprAiFNavigation { get; set; }
        public virtual CuentaContable? CtaDeprDesmantelaCNavigation { get; set; }
        public virtual CuentaContable? CtaDeprDesmantelaFNavigation { get; set; }
        public virtual CuentaContable? CtaDeprNormalCNavigation { get; set; }
        public virtual CuentaContable CtaDeprNormalNavigation { get; set; } = null!;
        public virtual CuentaContable? CtaDeprRevalCNavigation { get; set; }
        public virtual CuentaContable CtaDeprRevalNavigation { get; set; } = null!;
        public virtual TipoActivo TipoActivoNavigation { get; set; } = null!;
    }
}
