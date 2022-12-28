using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class SoftlandBiFaListaPrecio
    {
        public string Articulo { get; set; } = null!;
        public string ArticuloDescripcion { get; set; } = null!;
        public string? TipoArticulo { get; set; }
        public string? CalseAbcArticulo { get; set; }
        public string? ClasOriCorpArticulo { get; set; }
        public string ArticuloActivo { get; set; } = null!;
        public string? Clasificacion1 { get; set; }
        public string? Clasificacion2 { get; set; }
        public string? Clasificacion3 { get; set; }
        public string? Clasificacion4 { get; set; }
        public string? Clasificacion5 { get; set; }
        public string? Clasificacion6 { get; set; }
        public string? Proveedor { get; set; }
        public string DescripcionImpuesto { get; set; } = null!;
        public string? PeriodoNivel { get; set; }
        public string EstVersionNivPrecio { get; set; } = null!;
        public string NivelPrecio { get; set; } = null!;
        public string MonedaPrecio { get; set; } = null!;
        public int VersionNivelPrecio { get; set; }
        public decimal Precio { get; set; }
        public string? PeriodoPrecio { get; set; }
    }
}
