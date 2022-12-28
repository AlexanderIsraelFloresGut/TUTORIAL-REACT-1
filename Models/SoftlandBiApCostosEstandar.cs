using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class SoftlandBiApCostosEstandar
    {
        public string Estructura { get; set; } = null!;
        public string VersionEstructura { get; set; } = null!;
        public string EstadoEstructura { get; set; } = null!;
        public string? PeriodoEstructura { get; set; }
        public string? FechaProximaRevision { get; set; }
        public int? MesProximaRevision { get; set; }
        public decimal LoteStd { get; set; }
        public decimal CostoMaterialesLoteStd { get; set; }
        public decimal? CostoManoObraLoteStd { get; set; }
        public decimal? CostosDirectosLoteStd { get; set; }
        public decimal CostosIndirectosLoteStd { get; set; }
        public decimal? CostoTotalLoteStd { get; set; }
        public decimal? CostoUnitarioxUndloteStd { get; set; }
        public decimal CostoUnitarioStdenInventario { get; set; }
        public decimal? DifCostosUnitariosStd { get; set; }
        public decimal? CostoTotalSubproductos { get; set; }
        public decimal? CostoUnitSubprodUndLoteStd { get; set; }
    }
}
