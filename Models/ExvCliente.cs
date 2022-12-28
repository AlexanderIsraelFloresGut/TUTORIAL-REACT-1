using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class ExvCliente
    {
        public Guid RowPointer { get; set; }
        public decimal? Frecuencia { get; set; }
        public string? Jueves { get; set; }
        public string? Latitud { get; set; }
        public string? Longitud { get; set; }
        public string? Lunes { get; set; }
        public string? Martes { get; set; }
        public string? Miercoles { get; set; }
        public string? Periodicidad { get; set; }
        public string? Sabado { get; set; }
        public string? Viernes { get; set; }
    }
}
