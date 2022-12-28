using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class SoftlandBiPcImprevisto
    {
        public string OrdenProduccion { get; set; } = null!;
        public string? EstadoOrden { get; set; }
        public string Articulo { get; set; } = null!;
        public string? TipoArticulo { get; set; }
        public string Operacion { get; set; } = null!;
        public DateTime FechaHoraProducion { get; set; }
        public int? DiaProduccion { get; set; }
        public int? MesProduccion { get; set; }
        public int? TrimestreProduccion { get; set; }
        public int? AnnoProduccion { get; set; }
        public string? ParoMotivo { get; set; }
        public decimal? ParoMinutosDuracion { get; set; }
        public decimal? ParoHorasDuracion { get; set; }
        public string? DesperdicioArticulo { get; set; }
        public string? DesperdicioArtDescripcion { get; set; }
        public decimal? DesperdicioCantidad { get; set; }
        public DateTime? CostVariosFechaTrans { get; set; }
        public string? CostVariosDescripcion { get; set; }
        public string? CostVariosTipo { get; set; }
        public decimal? CostVariosCostoLocal { get; set; }
        public decimal? CostVariosCostoDolar { get; set; }
        public string Clasificacion1 { get; set; } = null!;
        public string Clasificacion2 { get; set; } = null!;
        public string Clasificacion3 { get; set; } = null!;
        public string Clasificacion4 { get; set; } = null!;
        public string Clasificacion5 { get; set; } = null!;
        public string Clasificacion6 { get; set; } = null!;
    }
}
