using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class FormatoPlanificacion
    {
        public string Planificador { get; set; } = null!;
        public string? Descripcion { get; set; }
        public string Conjunto { get; set; } = null!;
        public string TipoPeriodo { get; set; } = null!;
        public DateTime? FechaTransacciones { get; set; }
        public string BaseSugerencia { get; set; } = null!;
        public string Movimientos { get; set; } = null!;
        public int TiempoReaprovisionamiento { get; set; }
        public int FrecuenciaPedido { get; set; }
        public int InventarioSeguridad { get; set; }
        public int CantidadPeriodos { get; set; }
        public string ArticConMovimientos { get; set; } = null!;
        public string DesplegarSinSugerencia { get; set; } = null!;
        public string SoloConExistencia { get; set; } = null!;
        public string FechaBase { get; set; } = null!;
        public string CalcularHasta { get; set; } = null!;
        public string Costo { get; set; } = null!;
        public string Moneda { get; set; } = null!;
        public string IncluirCantTrans { get; set; } = null!;
        public string? BodegaDesde { get; set; }
        public string? BodegaDesdeDesc { get; set; }
        public string? BodegaHasta { get; set; }
        public string? BodegaHastaDesc { get; set; }
        public string Estado { get; set; } = null!;
        public string PeriodoLeadTime { get; set; } = null!;
        public string? ArticuloDesde { get; set; }
        public string? ArticuloDesdeDesc { get; set; }
        public string? ArticuloHasta { get; set; }
        public string? ArticuloHastaDesc { get; set; }
        public string? PronosticoVentas { get; set; }
        public string? PronosticoVentasDesc { get; set; }
        public string Generacion { get; set; } = null!;
        public string TipoGrafico { get; set; } = null!;
        public string SugeridoEnCero { get; set; } = null!;
        public string? ProveedorDesde { get; set; }
        public string? ProveedorHasta { get; set; }
        public string? ProveedorDesdeDesc { get; set; }
        public string? ProveedorHastaDesc { get; set; }
        public string? Clasificacion1Desde { get; set; }
        public string? Clasificacion1Hasta { get; set; }
        public string? Clasificacion2Desde { get; set; }
        public string? Clasificacion2Hasta { get; set; }
        public string? Clasificacion3Desde { get; set; }
        public string? Clasificacion3Hasta { get; set; }
        public string? Clasificacion4Desde { get; set; }
        public string? Clasificacion4Hasta { get; set; }
        public string? Clasificacion5Desde { get; set; }
        public string? Clasificacion5Hasta { get; set; }
        public string? Clasificacion6Desde { get; set; }
        public string? Clasificacion6Hasta { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
    }
}
