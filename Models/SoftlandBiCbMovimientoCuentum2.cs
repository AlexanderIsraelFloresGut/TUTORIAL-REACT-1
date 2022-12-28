using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class SoftlandBiCbMovimientoCuentum2
    {
        public string CuentaBancaria { get; set; } = null!;
        public string NombreCuentaBancaria { get; set; } = null!;
        public string MonedaCuenta { get; set; } = null!;
        public string CuentaActiva { get; set; } = null!;
        public string EntidadFinanciera { get; set; } = null!;
        public string DescripcionEntidadFinanciera { get; set; } = null!;
        public string TipoDocumento { get; set; } = null!;
        public string SubtipoDocumento { get; set; } = null!;
        public decimal NumeroDocumento { get; set; }
        public string DocumentoAnulado { get; set; } = null!;
        public string DocumentoAprobado { get; set; } = null!;
        public string? ModuloOrigen { get; set; }
        public decimal Monto { get; set; }
        public decimal? MontoAfecta { get; set; }
        public DateTime Fecha { get; set; }
        public int? AnoFecha { get; set; }
        public int? TrimestreFecha { get; set; }
        public int? MesFecha { get; set; }
        public int? SemanaFecha { get; set; }
        public string? Proveedor { get; set; }
        public string? NombreProveedor { get; set; }
        public string PagaderoA { get; set; } = null!;
        public int? NumeroConciliacion { get; set; }
        public string? EstadoDocumento { get; set; }
    }
}
