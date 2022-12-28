using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class SoftlandBiApRptMateriale1
    {
        public string CodigoArticuloEstructura { get; set; } = null!;
        public string DescripcionArticuloEstructura { get; set; } = null!;
        public string VersionEstructura { get; set; } = null!;
        public string EstadoEstructura { get; set; } = null!;
        public string NaturalezaComponente { get; set; } = null!;
        public string Operacion { get; set; } = null!;
        public string? TipoComponente { get; set; }
        public string? Componente { get; set; }
        public decimal CantidadComponente { get; set; }
        public decimal CostoUnitarioComponente { get; set; }
        public decimal? CostoTotalComponente { get; set; }
        public decimal PorcDesperdicioComponente { get; set; }
        public decimal? CantidadDesperdicio { get; set; }
        public decimal? CostoDesperdicio { get; set; }
    }
}
