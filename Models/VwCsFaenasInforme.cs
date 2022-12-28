using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class VwCsFaenasInforme
    {
        public int? AñoRecepcion { get; set; }
        public int? MesRecepcion { get; set; }
        public string Faena { get; set; } = null!;
        public string? Proveedor { get; set; }
        public string Nombre { get; set; } = null!;
        public string? EstadoFaena { get; set; }
        public DateTime? FechaSalida { get; set; }
        public DateTime? FechaRecepcion { get; set; }
    }
}
