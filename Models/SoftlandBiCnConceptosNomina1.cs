using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class SoftlandBiCnConceptosNomina1
    {
        public string EstadoEmpleado { get; set; } = null!;
        public string Sexo { get; set; } = null!;
        public string Empleado { get; set; } = null!;
        public string CentroCosto { get; set; } = null!;
        public string Departamento { get; set; } = null!;
        public string Puesto { get; set; } = null!;
        public string Nomina { get; set; } = null!;
        public string EstadoNomina { get; set; } = null!;
        public string MonedaNomina { get; set; } = null!;
        public short NumeroNomina { get; set; }
        public string? FechasNomina { get; set; }
        public int? AñoNomina { get; set; }
        public int? TrimestreNomina { get; set; }
        public int? MesNomina { get; set; }
        public string Concepto { get; set; } = null!;
        public string TipoConcepto { get; set; } = null!;
        public decimal CantidadConcepto { get; set; }
        public decimal MontoConcepto { get; set; }
        public decimal TotalConcepto { get; set; }
    }
}
