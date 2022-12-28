using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class VwTransaccionesEntradum
    {
        public string Articulo { get; set; } = null!;
        public string DescripcionArticulo { get; set; } = null!;
        public string EstadoArticulo { get; set; } = null!;
        public string? TipoArticulo { get; set; }
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
        public string? Bodega { get; set; }
        public string NombreBodega { get; set; } = null!;
        public string Documento { get; set; } = null!;
        public string Usuario { get; set; } = null!;
        public string ModuloOrigen { get; set; } = null!;
        public DateTime? FechaAuditoria { get; set; }
        public int? AnoFechaAuditoria { get; set; }
        public int? TrimestreFechaAuditoria { get; set; }
        public int? MesFechaAuditoria { get; set; }
        public DateTime? FechaDocumento { get; set; }
        public int? AnoFechaDocumento { get; set; }
        public int? TrimestreFechaDocumento { get; set; }
        public int? MesFechaDocumento { get; set; }
        public DateTime? FechaTransaccion { get; set; }
        public int? AnoFechaTransaccion { get; set; }
        public int? TrimestreFechaTransaccion { get; set; }
        public int? MesFechaTransaccion { get; set; }
        public string AjusteConfigurable { get; set; } = null!;
        public string? Tipo { get; set; }
        public string? Subtipo { get; set; }
        public string? Subsubtipo { get; set; }
        public string? Naturaleza { get; set; }
        public decimal? Cantidad { get; set; }
        public decimal? CostoTotalFiscalLocal { get; set; }
        public decimal? CostoTotalFiscalDolar { get; set; }
        public decimal? CostoTotalComparativoLocal { get; set; }
        public decimal? CostoTotalComparativoDolar { get; set; }
        public string TransaccionContabilizada { get; set; } = null!;
        public string GrupoContable { get; set; } = null!;
        public string DescripcionGrupoContable { get; set; } = null!;
        public string CuentaInventario { get; set; } = null!;
        public string CentroInventario { get; set; } = null!;
        public string Referencia { get; set; } = null!;
    }
}
