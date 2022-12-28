using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class VwEmpleadosVacacionesTomada
    {
        public string Compania { get; set; } = null!;
        public string Empleado { get; set; } = null!;
        public string? Trimestre { get; set; }
        public int? Anio { get; set; }
        public decimal? Saldo { get; set; }
    }
}
