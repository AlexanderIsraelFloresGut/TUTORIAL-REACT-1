using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class SoftlandBiCcSaldoCliente
    {
        public string Cliente { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public string CategoriaDeCliente { get; set; } = null!;
        public string NombreCategoriaDeCliente { get; set; } = null!;
        public string? ClaseAbc { get; set; }
        public string Moneda { get; set; } = null!;
        public decimal Saldo { get; set; }
        public decimal SaldoLocal { get; set; }
        public decimal SaldoDolar { get; set; }
        public decimal TasaInteres { get; set; }
        public decimal TasaInteresMora { get; set; }
        public string Activo { get; set; } = null!;
        public string Multimoneda { get; set; } = null!;
        public string EsCorporacion { get; set; } = null!;
        public string? ClienteCorporacion { get; set; }
        public string Pais { get; set; } = null!;
        public string NombrePais { get; set; } = null!;
        public string Zona { get; set; } = null!;
        public string NombreZona { get; set; } = null!;
        public string Ruta { get; set; } = null!;
        public string DescripcionRuta { get; set; } = null!;
        public string? Vendedor { get; set; }
        public string? NombreVendedor { get; set; }
        public string Cobrador { get; set; } = null!;
        public string NombreCobrador { get; set; } = null!;
        public DateTime FechaRegistro { get; set; }
        public int? AnoFechaRegistro { get; set; }
        public int? TrimestreFechaRegistro { get; set; }
        public int? MesFechaRegistro { get; set; }
    }
}
