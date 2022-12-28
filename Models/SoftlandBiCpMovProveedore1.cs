using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class SoftlandBiCpMovProveedore1
    {
        public string Proveedor { get; set; } = null!;
        public string NombreProveedor { get; set; } = null!;
        public string CategoriaProveedor { get; set; } = null!;
        public string NombreCategoriaProveedor { get; set; } = null!;
        public string ProveedorActivo { get; set; } = null!;
        public string Tipo { get; set; } = null!;
        public string Multimoneda { get; set; } = null!;
        public string PaisProveedor { get; set; } = null!;
        public string NombrePaisProveedor { get; set; } = null!;
        public string CondicionDePagoProveedor { get; set; } = null!;
        public string DescripcionCondicionDePago { get; set; } = null!;
        public string Documento { get; set; } = null!;
        public string TipoDocumento { get; set; } = null!;
        public string SubtipoDocumento { get; set; } = null!;
        public string DocumentoAnulado { get; set; } = null!;
        public string DocumentoAprobado { get; set; } = null!;
        public DateTime FechaDocumento { get; set; }
        public int? AnoFechaDocumento { get; set; }
        public int? TrimestreFechaDocumento { get; set; }
        public int? MesFechaDocumento { get; set; }
        public int? MesesAntiguedad { get; set; }
        public int? DiasAntiguedad { get; set; }
        public string? RangoAntiguedad { get; set; }
        public DateTime FechaRige { get; set; }
        public int? AnoFechaRige { get; set; }
        public int? TrimestreFechaRige { get; set; }
        public int? MesFechaRige { get; set; }
        public int? MesesAntiguedadRige { get; set; }
        public int? DiasAntiguedadRige { get; set; }
        public string? RangoAntiguedadRige { get; set; }
        public DateTime FechaVence { get; set; }
        public int? AnoFechaVence { get; set; }
        public int? TrimestreFechaVence { get; set; }
        public int? MesFechaVence { get; set; }
        public int? MesesVencimiento { get; set; }
        public int? DiasVencimiento { get; set; }
        public string? RangoVencimiento { get; set; }
        public string Moneda { get; set; } = null!;
        public decimal Monto { get; set; }
        public decimal Saldo { get; set; }
        public decimal MontoLocal { get; set; }
        public decimal SaldoLocal { get; set; }
        public decimal MontoDolar { get; set; }
        public decimal SaldoDolar { get; set; }
        public decimal MontoRetencion { get; set; }
        public decimal SaldoRetencion { get; set; }
        public decimal? MontoAfectaLocal { get; set; }
        public decimal? SaldoAfectaLocal { get; set; }
        public decimal? MontoAfectaDolar { get; set; }
        public decimal? SaldoAfectaDolar { get; set; }
    }
}
