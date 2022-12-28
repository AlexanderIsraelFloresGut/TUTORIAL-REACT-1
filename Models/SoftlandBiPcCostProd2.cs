using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class SoftlandBiPcCostProd2
    {
        public string OrdenProduccion { get; set; } = null!;
        public string? EstadoOrden { get; set; }
        public string Articulo { get; set; } = null!;
        public string? TipoArticulo { get; set; }
        public string Clasificacion1 { get; set; } = null!;
        public string Clasificacion2 { get; set; } = null!;
        public string Clasificacion3 { get; set; } = null!;
        public string Clasificacion4 { get; set; } = null!;
        public string Clasificacion5 { get; set; } = null!;
        public string Clasificacion6 { get; set; } = null!;
        public decimal? CantidadProducida { get; set; }
        public decimal CantidadEstandar { get; set; }
        public decimal CostoEstimadoGif { get; set; }
        public decimal CostoEstimadoMateriales { get; set; }
        public decimal? CostoEstimadoMo { get; set; }
        public decimal? CostoTotalEstimado { get; set; }
        public decimal? CostoUnitarioEstimado { get; set; }
        public decimal CostoRealGif { get; set; }
        public decimal CostoRealMateriales { get; set; }
        public decimal? CostoRealMo { get; set; }
        public decimal? CostoTotalReal { get; set; }
        public decimal? CostoUnitarioReal { get; set; }
        public decimal? DifCostosUnitarios { get; set; }
        public decimal? DifCostoTotales { get; set; }
    }
}
