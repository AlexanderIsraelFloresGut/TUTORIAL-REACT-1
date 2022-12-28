using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class Faena
    {
        public int Id { get; set; }
        public int Barco { get; set; }
        public int DiasFaena { get; set; }
        public int DiasSinFaena { get; set; }
        public DateTime Periodo { get; set; }
        public string? HostCreacion { get; set; }
        public DateTime? FechaCreacion { get; set; }
    }
}
