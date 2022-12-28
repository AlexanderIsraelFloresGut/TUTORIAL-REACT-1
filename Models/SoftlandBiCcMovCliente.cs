using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class SoftlandBiCcMovCliente
    {
        public string Cliente { get; set; } = null!;
        public string NombreCliente { get; set; } = null!;
        public string CategoriaDeCliente { get; set; } = null!;
        public string NombreCategoriaDeCliente { get; set; } = null!;
        public string? ClaseAbc { get; set; }
        public string Activo { get; set; } = null!;
        public string DocumentoAnulado { get; set; } = null!;
        public string DocumentoAprobado { get; set; } = null!;
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
        public string Documento { get; set; } = null!;
        public string TipoDocumento { get; set; } = null!;
        public string SubtipoDocumento { get; set; } = null!;
        public DateTime FechaDocumento { get; set; }
        public int? AnoFechaDocumento { get; set; }
        public int? TrimestreFechaDocumento { get; set; }
        public int? MesFechaDocumento { get; set; }
        public int? DiasAntiguedad { get; set; }
        public int? MesesAntiguedad { get; set; }
        public string? RangoAntiguedadDocumento { get; set; }
        public DateTime FechaRige { get; set; }
        public int? AnoFechaRige { get; set; }
        public int? TrimestreFechaRige { get; set; }
        public int? MesFechaRige { get; set; }
        public int? DiasAntiguedadRige { get; set; }
        public int? MesesAntiguedadRige { get; set; }
        public string? RangoAntiguedadRige { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public int? AnoFechaVencimiento { get; set; }
        public int? TrimestreFechaVencimiento { get; set; }
        public int? MesFechaVencimiento { get; set; }
        public int? DiasVencimiento { get; set; }
        public int? MesesVencimiento { get; set; }
        public string? RangoVencimientoDocumento { get; set; }
        public string MonedaDocumento { get; set; } = null!;
        public decimal Monto { get; set; }
        public decimal Saldo { get; set; }
        public decimal MontoLocal { get; set; }
        public decimal SaldoLocal { get; set; }
        public decimal MontoDolar { get; set; }
        public decimal SaldoDolar { get; set; }
        public decimal MontoRetencion { get; set; }
        public decimal SaldoRetencion { get; set; }
        public short NumeroDeParcialidades { get; set; }
        public decimal? MontoAfectaLocal { get; set; }
        public decimal? SaldoAfectaLocal { get; set; }
        public decimal? MontoAfectaDolar { get; set; }
        public decimal? SaldoAfectaDolar { get; set; }
    }
}
