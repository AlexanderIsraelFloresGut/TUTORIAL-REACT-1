using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class SoftlandBiArticulo1
    {
        public string Codigo { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public string CodigoNombre { get; set; } = null!;
        public string Clasificacion1 { get; set; } = null!;
        public string Clasificacion2 { get; set; } = null!;
        public string Clasificacion3 { get; set; } = null!;
        public string Clasificacion4 { get; set; } = null!;
        public string Clasificacion5 { get; set; } = null!;
        public string Clasificacion6 { get; set; } = null!;
        public string Tipo { get; set; } = null!;
        public string Claseabc { get; set; } = null!;
        public string Unidadalmacen { get; set; } = null!;
        public decimal Factorempaque { get; set; }
        public string Unidaddetalle { get; set; } = null!;
        public decimal Factorventa { get; set; }
        public string Unidadventa { get; set; } = null!;
        public decimal Pesobruto { get; set; }
        public decimal Pesoneto { get; set; }
        public decimal Volumen { get; set; }
    }
}
