using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class VwOtFecha
    {
        public string Empresa { get; set; } = null!;
        public int OtNo { get; set; }
        public string DescripcionCorta { get; set; } = null!;
        public DateTime? FechaSolicitud { get; set; }
        public DateTime? FechaEntrega { get; set; }
        public DateTime FechaOrden { get; set; }
        public DateTime FechaRequerida { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime? FechaLiberacion { get; set; }
        public DateTime? FechaCierre { get; set; }
    }
}
