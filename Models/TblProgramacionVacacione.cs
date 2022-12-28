using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class TblProgramacionVacacione
    {
        public int Id { get; set; }
        public string Compania { get; set; } = null!;
        public string Empleado { get; set; } = null!;
        public string Trimestre { get; set; } = null!;
        public int Anio { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public decimal DiasPendientes { get; set; }
        public decimal DiasProgramados { get; set; }
    }
}
