using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class VwEmpleado
    {
        public string Compania { get; set; } = null!;
        public string Empleado { get; set; } = null!;
        public string? Nombre { get; set; }
        public string Puesto { get; set; } = null!;
    }
}
