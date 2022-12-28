using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class SoftlandBiCiExistencia
    {
        public string Articulo { get; set; } = null!;
        public string DescripcionArticulo { get; set; } = null!;
        public string EstadoArticulo { get; set; } = null!;
        public string? Tipo { get; set; }
        public string? Origen { get; set; }
        public string ClaseArticulo { get; set; } = null!;
        public string? Clasificacion1 { get; set; }
        public string? Clasificacion2 { get; set; }
        public string? Clasificacion3 { get; set; }
        public string? Clasificacion4 { get; set; }
        public string? Clasificacion5 { get; set; }
        public string? Clasificacion6 { get; set; }
        public string UnidadAlmacen { get; set; } = null!;
        public string DescripcionUnidadAlmacen { get; set; } = null!;
        public string Proveedor { get; set; } = null!;
        public string NombreProveedor { get; set; } = null!;
        public string PaisProveedor { get; set; } = null!;
        public string NombrePaisProveedor { get; set; } = null!;
        public decimal PesoNetoArticulo { get; set; }
        public decimal PesoBrutoArticulo { get; set; }
        public decimal VolumenArticulo { get; set; }
        public string Bodega { get; set; } = null!;
        public string NombreBodega { get; set; } = null!;
        public decimal CantidadDisponible { get; set; }
        public decimal CantidadReservada { get; set; }
        public decimal CantidadNoAprobada { get; set; }
        public decimal CantidadVencida { get; set; }
        public decimal CantidadTransito { get; set; }
        public decimal CantidadProduccion { get; set; }
        public decimal CantidadPedida { get; set; }
        public decimal CantidadRemitida { get; set; }
    }
}
