using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class UsuarioActual
    {
        public short ConexionId { get; set; }
        public string Usuario { get; set; } = null!;
        public DateTime FechaHora { get; set; }
    }
}
