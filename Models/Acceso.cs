using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class Acceso
    {
        public int IdAcceso { get; set; }
        public int IdUsuario { get; set; }
        public int IdTipoMenu { get; set; }
        public DateTime? FechaCreado { get; set; }
    }
}
