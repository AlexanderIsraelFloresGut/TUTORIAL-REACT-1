using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class CsEmpleadoArea
    {
        public string Empleado { get; set; } = null!;
        public Guid Area { get; set; }

        public virtual CsAreaOrg AreaNavigation { get; set; } = null!;
        public virtual Empleado1 EmpleadoNavigation { get; set; } = null!;
    }
}
