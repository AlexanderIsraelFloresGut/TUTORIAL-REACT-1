using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class CpNotasCred
    {
        public string Asiento { get; set; } = null!;
        public int Consecutivo { get; set; }
        public string CuentaContable { get; set; } = null!;
        public string NombreCuenta { get; set; } = null!;
        public string Referencia { get; set; } = null!;
        public string Fuente { get; set; } = null!;
        public DateTime Fecha { get; set; }
        public DateTime FechaCreacion { get; set; }
        public decimal? DebitoLocal { get; set; }
        public decimal? DebitoDolar { get; set; }
        public decimal? CreditoLocal { get; set; }
        public decimal? CreditoDolar { get; set; }
        public string TipoAsiento { get; set; } = null!;
        public string ClaseAsiento { get; set; } = null!;
        public string Paquete { get; set; } = null!;
        public string Origen { get; set; } = null!;
        public string? AsientoOr { get; set; }
        public string CentroCosto { get; set; } = null!;
        public string NombreCentroCosto { get; set; } = null!;
    }
}
