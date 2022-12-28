using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class CentroConcepto2
    {
        public CentroConcepto2()
        {
            EmpleadoConcNomi2s = new HashSet<EmpleadoConcNomi2>();
        }

        public string CentroCosto { get; set; } = null!;
        public string Concepto { get; set; } = null!;
        public string Activo { get; set; } = null!;
        public string? CuentaContable { get; set; }
        public string? CuentaContra { get; set; }

        public virtual CentroCosto2 CentroCostoNavigation { get; set; } = null!;
        public virtual Concepto2 ConceptoNavigation { get; set; } = null!;
        public virtual CuentaContable2? CuentaContableNavigation { get; set; }
        public virtual CuentaContable2? CuentaContraNavigation { get; set; }
        public virtual ICollection<EmpleadoConcNomi2> EmpleadoConcNomi2s { get; set; }
    }
}
