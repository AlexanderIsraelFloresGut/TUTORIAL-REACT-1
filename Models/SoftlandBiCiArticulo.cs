using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class SoftlandBiCiArticulo
    {
        public string Articulo { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public string? Tipo { get; set; }
        public string? Origen { get; set; }
        public string? CostoFiscal { get; set; }
        public decimal? CostoFiscalLocal { get; set; }
        public decimal? CostoFiscalDolar { get; set; }
        public string? CostoComparativo { get; set; }
        public decimal? CostoComparativoLocal { get; set; }
        public decimal? CostoComparativoDolar { get; set; }
        public DateTime UltimaSalida { get; set; }
        public int? AnoUltimaSalida { get; set; }
        public int? MesUltimaSalida { get; set; }
        public DateTime UltimoIngreso { get; set; }
        public int? AnoUltimoIngreso { get; set; }
        public int? MesUltimoIngreso { get; set; }
        public DateTime UltimoInventario { get; set; }
        public int? AnoUltimoInventario { get; set; }
        public int? MesUltimoInventario { get; set; }
        public DateTime UltimoMovimiento { get; set; }
        public int? AnoUltimoMovimiento { get; set; }
        public int? MesUltimoMovimiento { get; set; }
        public string GrupoContable { get; set; } = null!;
        public string DescripcionGrupoContable { get; set; } = null!;
        public string CuentaInventario { get; set; } = null!;
        public string CentroInventario { get; set; } = null!;
        public string Impuesto { get; set; } = null!;
        public string DescripcionImpuesto { get; set; } = null!;
        public string Proveedor { get; set; } = null!;
        public string NombreProveedor { get; set; } = null!;
        public string? Clasificacion1 { get; set; }
        public string? Clasificacion2 { get; set; }
        public string? Clasificacion3 { get; set; }
        public string? Clasificacion4 { get; set; }
        public string? Clasificacion5 { get; set; }
        public string? Clasificacion6 { get; set; }
        public string Estado { get; set; } = null!;
        public string UsaLotes { get; set; } = null!;
        public string ClaseArticulo { get; set; } = null!;
        public decimal ExistenciaMinima { get; set; }
        public decimal ExistenciaMaxima { get; set; }
        public decimal PuntoDeReorden { get; set; }
        public string UnidadAlmacen { get; set; } = null!;
        public string DescripcionUnidadAlmacen { get; set; } = null!;
    }
}
