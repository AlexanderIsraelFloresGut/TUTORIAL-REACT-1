using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class EmpleadoComprobante
    {
        public string Empleado { get; set; } = null!;
        public string Nomina { get; set; } = null!;
        public short NumeroNomina { get; set; }
        public string Usuario { get; set; } = null!;
        public string GuidComprobante { get; set; } = null!;

        public virtual Empleado EmpleadoNavigation { get; set; } = null!;
        public virtual Usuario2 UsuarioNavigation { get; set; } = null!;
    }
}
