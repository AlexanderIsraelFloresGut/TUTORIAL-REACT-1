using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class SoftlandBiCnSalario1
    {
        public string? EstadoEmpleado { get; set; }
        public string? Empleado { get; set; }
        public string? CentroCosto { get; set; }
        public string? Departamento { get; set; }
        public string? Puesto { get; set; }
        public string? Sexo { get; set; }
        public string? Nomina { get; set; }
        public short? NumeroNomina { get; set; }
        public string? FechasNomina { get; set; }
        public int? AnoNomina { get; set; }
        public int? TrimestreNomina { get; set; }
        public int? MesNomina { get; set; }
        public decimal? MontoBeneficios { get; set; }
        public decimal? MontoDeducciones { get; set; }
        public decimal? MontoAnticipos { get; set; }
        public decimal? MontoAportes { get; set; }
        public decimal? Neto { get; set; }
        public int? DiasAntiguedad { get; set; }
        public int? MesesAntiguedad { get; set; }
        public int? AnosAntiguedad { get; set; }
        public string EstadoNomina { get; set; } = null!;
        public string MonedaNomina { get; set; } = null!;
    }
}
