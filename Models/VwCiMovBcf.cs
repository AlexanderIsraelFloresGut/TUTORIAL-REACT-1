using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class VwCiMovBcf
    {
        public int? Año { get; set; }
        public int? Mes { get; set; }
        public DateTime Fecha { get; set; }
        public string Documento { get; set; } = null!;
        public string ModuloOrigen { get; set; } = null!;
        public string? Bodega { get; set; }
        public string NombreBodega { get; set; } = null!;
        public string Usuario { get; set; } = null!;
        public string? Naturaleza { get; set; }
        public string AjusteConfigurable { get; set; } = null!;
        public string? Tipo { get; set; }
        public string? Subtipo { get; set; }
        public string Articulo { get; set; } = null!;
        public string DescripcionArticulo { get; set; } = null!;
        public decimal? Cantidad { get; set; }
        public decimal? CostoTNio { get; set; }
        public decimal? CostoTUsd { get; set; }
    }
}
