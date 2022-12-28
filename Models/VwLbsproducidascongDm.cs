using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class VwLbsproducidascongDm
    {
        public string Articulo { get; set; } = null!;
        public string DescripcionArticulo { get; set; } = null!;
        public string EstadoArticulo { get; set; } = null!;
        public string? TipoArticulo { get; set; }
        public string? Torigen { get; set; }
        public string ClaseArticulo { get; set; } = null!;
        public string? TipoArt { get; set; }
        public string? Especie { get; set; }
        public string? Subespecie { get; set; }
        public string? Tipovta { get; set; }
        public string? Talla { get; set; }
        public string? Origen { get; set; }
        public string UnidadAlmacen { get; set; } = null!;
        public string DescripcionUnidadAlmacen { get; set; } = null!;
        public string? Bodega { get; set; }
        public string NombreBodega { get; set; } = null!;
        public string Documento { get; set; } = null!;
        public string Usuario { get; set; } = null!;
        public string ModuloOrigen { get; set; } = null!;
        public DateTime FechaDocumento { get; set; }
        public int? MesFechaDocumento { get; set; }
        public int? AnoFechaDocumento { get; set; }
        public string AjusteConfigurable { get; set; } = null!;
        public string? Tipo { get; set; }
        public string? Subtipo { get; set; }
        public string? Subsubtipo { get; set; }
        public string? Naturaleza { get; set; }
        public decimal? Cantidad { get; set; }
        public decimal? CostoC { get; set; }
        public decimal? Costou { get; set; }
        public string Empresa { get; set; } = null!;
    }
}
