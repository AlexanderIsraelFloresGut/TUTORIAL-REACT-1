using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class SpArticulo2
    {
        public string Articulo { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public string? Clasificacion1 { get; set; }
        public string? Clasificacion2 { get; set; }
        public string? Clasificacion3 { get; set; }
        public string? Clasificacion4 { get; set; }
        public string? Clasificacion5 { get; set; }
        public string? Clasificacion6 { get; set; }
        public string Tipo { get; set; } = null!;
        public string Impuesto { get; set; } = null!;
        public decimal ExistenciaMinima { get; set; }
        public decimal ExistenciaMaxima { get; set; }
        public decimal PuntoDeReorden { get; set; }
        public decimal CostoPromLoc { get; set; }
        public decimal CostoPromDol { get; set; }
        public string ClaseAbc { get; set; } = null!;
        public short FrecuenciaConteo { get; set; }
        public string Activo { get; set; } = null!;
        public string? Proveedor { get; set; }
        public string UnidadAlmacen { get; set; } = null!;
        public string UnidadEmpaque { get; set; } = null!;
        public DateTime? UltimoIngreso { get; set; }
        public string? ArticuloDelProv { get; set; }
        public decimal? LoteMultiplo { get; set; }
        public decimal? OrdenMinima { get; set; }
        public short? PlazoReabast { get; set; }
        public string? CostoFiscal { get; set; }
        public string? CostoComparativo { get; set; }
        public decimal? FactorEmpaque { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
    }
}
