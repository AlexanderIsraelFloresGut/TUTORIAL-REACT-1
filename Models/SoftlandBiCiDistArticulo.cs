using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class SoftlandBiCiDistArticulo
    {
        public string Activo { get; set; } = null!;
        public string Articulo { get; set; } = null!;
        public string ArticuloDescripcion { get; set; } = null!;
        public string? TipoArticulo { get; set; }
        public string? Clasificacion1 { get; set; }
        public string? Clasificacion2 { get; set; }
        public string? Clasificacion3 { get; set; }
        public string? Clasificacion4 { get; set; }
        public string? Clasificacion5 { get; set; }
        public string? Clasificacion6 { get; set; }
        public string UnidadMedida { get; set; } = null!;
        public string CodigoBodega { get; set; } = null!;
        public string Bodega { get; set; } = null!;
        public decimal CantDisponible { get; set; }
        public decimal CantReservada { get; set; }
        public decimal CantNoAprobada { get; set; }
        public decimal CantVencida { get; set; }
        public decimal CantTransito { get; set; }
        public decimal CantProduccion { get; set; }
        public decimal CantPedida { get; set; }
        public decimal CantRemitida { get; set; }
        public decimal PesoNeto { get; set; }
        public decimal PesoBruto { get; set; }
        public decimal Volumen { get; set; }
    }
}
