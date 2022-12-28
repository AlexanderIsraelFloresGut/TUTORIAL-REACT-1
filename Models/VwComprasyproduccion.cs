using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class VwComprasyproduccion
    {
        public int? Año { get; set; }
        public int? Mes { get; set; }
        public DateTime FechaDocumento { get; set; }
        public string? Bodega { get; set; }
        public string Articulo { get; set; } = null!;
        public string DescripcionArticulo { get; set; } = null!;
        public string Documento { get; set; } = null!;
        public string Usuario { get; set; } = null!;
        public string AjusteConfigurable { get; set; } = null!;
        public string? Tipo { get; set; }
        public string? Subtipo { get; set; }
        public string? Naturaleza { get; set; }
        public decimal? Cantidad { get; set; }
        public decimal? CostoTotalFiscalLocal { get; set; }
        public decimal? CostoTotalFiscalDolar { get; set; }
        public string Empresa { get; set; } = null!;
    }
}
