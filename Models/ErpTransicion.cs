using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class ErpTransicion
    {
        public string Entidad { get; set; } = null!;
        public string Compania { get; set; } = null!;
        public string Accion { get; set; } = null!;
        public string Id { get; set; } = null!;
        public string? IdFinal { get; set; }
        public string? Json { get; set; }
        public DateTime Fecha { get; set; }
        public string? Estado { get; set; }
    }
}
