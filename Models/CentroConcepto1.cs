using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class CentroConcepto1
    {
        public CentroConcepto1()
        {
            EmpleadoConcNomi1s = new HashSet<EmpleadoConcNomi1>();
        }

        public string CentroCosto { get; set; } = null!;
        public string Concepto { get; set; } = null!;
        public string Activo { get; set; } = null!;
        public string? CuentaContable { get; set; }
        public string? CuentaContra { get; set; }

        public virtual CentroCosto1 CentroCostoNavigation { get; set; } = null!;
        public virtual Concepto1 ConceptoNavigation { get; set; } = null!;
        public virtual CuentaContable1? CuentaContableNavigation { get; set; }
        public virtual CuentaContable1? CuentaContraNavigation { get; set; }
        public virtual ICollection<EmpleadoConcNomi1> EmpleadoConcNomi1s { get; set; }
    }
}
