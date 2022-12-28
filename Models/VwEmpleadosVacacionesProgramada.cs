using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class VwEmpleadosVacacionesProgramada
    {
        public string Compania { get; set; } = null!;
        public string Empleado { get; set; } = null!;
        public string Trimestre { get; set; } = null!;
        public int Anio { get; set; }
        public decimal DiasProgramados { get; set; }
    }
}
