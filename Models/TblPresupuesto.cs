using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class TblPresupuesto
    {
        public int Id { get; set; }
        public bool? Exportacion { get; set; }
        public int? Anio { get; set; }
        public string? Mes { get; set; }
        public string? Origen { get; set; }
        public string? Especie { get; set; }
        public string? Tipo { get; set; }
        public string? Articulo { get; set; }
        public string? Descripcion { get; set; }
        public decimal? Cantidad { get; set; }
        public decimal? PrecioUnitDolar { get; set; }
        public decimal? PreicioUnitLocal { get; set; }
        public decimal? PrecioTotalDolar { get; set; }
        public decimal? PrecioTotalLocal { get; set; }
        public decimal? CostoTotalLocal { get; set; }
        public decimal? CostoTotalDolar { get; set; }
        public decimal? CostoUnitDolar { get; set; }
        public decimal? CostoUnitLocal { get; set; }
        public decimal? MargenUtilidadDolar { get; set; }
        public decimal? MargenUtilidadLocal { get; set; }
        public decimal? PorcUtil { get; set; }
        public decimal? Cif { get; set; }
        public decimal? PorcentajeCif { get; set; }
        public decimal? MargenBruto { get; set; }
        public decimal? Comercializacion { get; set; }
        public decimal? Fletes { get; set; }
        public decimal? Otros { get; set; }
        public decimal? Administrativos { get; set; }
        public decimal? Operativos { get; set; }
        public decimal? MargenNeto { get; set; }
    }
}
