using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class SoftlandBiCoArtProveedor
    {
        public string Articulo { get; set; } = null!;
        public string DescripcionArticulo { get; set; } = null!;
        public string EstadoArticulo { get; set; } = null!;
        public string Proveedor { get; set; } = null!;
        public string NombreProveedor { get; set; } = null!;
        public string PaisProveedor { get; set; } = null!;
        public string NombrePaisProveedor { get; set; } = null!;
        public short DiasAbastecimiento { get; set; }
        public decimal? LoteEstandar { get; set; }
        public decimal? LoteMinimo { get; set; }
        public decimal? LoteMaximo { get; set; }
        public decimal? MultiploCompra { get; set; }
        public DateTime? FechaUltimoPrecio { get; set; }
        public int? MesUltimoPrecio { get; set; }
        public int? AnoUltimoPrecio { get; set; }
    }
}
