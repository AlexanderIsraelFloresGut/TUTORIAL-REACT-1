using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class VwVistaregtodogasto
    {
        public int? Año { get; set; }
        public int? Mes { get; set; }
        public string ClasifProv { get; set; } = null!;
        public string Codigo { get; set; } = null!;
        public string NombreProveedor { get; set; } = null!;
        public string Documento { get; set; } = null!;
        public DateTime FechaDocumento { get; set; }
        public string Aplicacion { get; set; } = null!;
        public string Usuario { get; set; } = null!;
        public string Moneda { get; set; } = null!;
        public decimal? Tco1 { get; set; }
        public decimal Tco2 { get; set; }
        public decimal Monto { get; set; }
        public decimal Montoc { get; set; }
        public decimal Saldo { get; set; }
        public short? Subtipo { get; set; }
        public string DescripcionGastos { get; set; } = null!;
        public string? CodigoCtaccontable { get; set; }
        public string DescripcionCtacontable { get; set; } = null!;
        public string GastoSiesg { get; set; } = null!;
        public string Empresa { get; set; } = null!;
    }
}
