using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class SoftlandBiCpSaldoProveedore2
    {
        public string Proveedor { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public string Categoria { get; set; } = null!;
        public string NombreCategoria { get; set; } = null!;
        public string Tipo { get; set; } = null!;
        public string Activo { get; set; } = null!;
        public string Multimoneda { get; set; } = null!;
        public string Pais { get; set; } = null!;
        public string NombrePais { get; set; } = null!;
        public string CondicionDePago { get; set; } = null!;
        public string DescripcionCondicionDePago { get; set; } = null!;
        public string Moneda { get; set; } = null!;
        public decimal Saldo { get; set; }
        public decimal SaldoLocal { get; set; }
        public decimal SaldoDolar { get; set; }
        public decimal? TasaInteresMora { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int? AnoFechaRegistro { get; set; }
        public int? TrimestreFechaRegistro { get; set; }
        public int? MesFechaRegistro { get; set; }
    }
}
