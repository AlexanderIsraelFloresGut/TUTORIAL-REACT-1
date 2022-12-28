using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class CentroConcepto
    {
        public CentroConcepto()
        {
            EmpleadoConcNomis = new HashSet<EmpleadoConcNomi>();
        }

        public string CentroCosto { get; set; } = null!;
        public string Concepto { get; set; } = null!;
        public string Activo { get; set; } = null!;
        public string? CuentaContable { get; set; }
        public string? CuentaContra { get; set; }

        public virtual CentroCosto CentroCostoNavigation { get; set; } = null!;
        public virtual Concepto ConceptoNavigation { get; set; } = null!;
        public virtual CuentaContable? CuentaContableNavigation { get; set; }
        public virtual CuentaContable? CuentaContraNavigation { get; set; }
        public virtual ICollection<EmpleadoConcNomi> EmpleadoConcNomis { get; set; }
    }
}
