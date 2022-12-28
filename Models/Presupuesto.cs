using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class Presupuesto
    {
        public string? Exportacion { get; set; }
        public int? Anio { get; set; }
        public string? Mes { get; set; }
        public string? Origen { get; set; }
        public string? Especie { get; set; }
        public string? Tipo { get; set; }
        public string? Articulo { get; set; }
        public string? Descripcion { get; set; }
        public double? Cantidad { get; set; }
        public double? PrecioUnitDolar { get; set; }
        public double? PrecioUnitLocal { get; set; }
        public double? PrecioTotalDolar { get; set; }
        public double? PrecioTotalLocal { get; set; }
        public double? CostoTotalLocal { get; set; }
        public double? CostoTotalDolar { get; set; }
        public double? CostoUnitDolar { get; set; }
        public double? CostoUnitLocal { get; set; }
        public string? MargenUtilidadDolar { get; set; }
        public string? MargenUtilidadLocal { get; set; }
        public string? PorcUtil { get; set; }
        public double? Cif { get; set; }
        public string? PorcentajeCif { get; set; }
        public string? MargenBruto { get; set; }
        public double? Acopio { get; set; }
        public double? Comercializacion { get; set; }
        public double? Fletes { get; set; }
        public string? Otros { get; set; }
        public double? Administrativos { get; set; }
        public double? Operativos { get; set; }
        public string? MargenNeto { get; set; }
    }
}
