using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class SoftlandBiMetum
    {
        public int Meta { get; set; }
        public string Nombre { get; set; } = null!;
        public string Version { get; set; } = null!;
        public string Estado { get; set; } = null!;
        public DateTime Periodoinicial { get; set; }
        public int Cantidadperiodos { get; set; }
        public string Nombrereal { get; set; } = null!;
        public string Nombrepresupuesto { get; set; } = null!;
        public string Medida { get; set; } = null!;
        public string Dimensionprincipal { get; set; } = null!;
        public string Dimensionagrupamiento { get; set; } = null!;
        public decimal Limitesobresaliente { get; set; }
        public decimal Limiteexitoso { get; set; }
        public decimal Limitedeficiente { get; set; }
        public decimal Limitecritico { get; set; }
    }
}
