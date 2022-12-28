using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class VwPagosefectivoBef
    {
        public int? Año { get; set; }
        public int? Mes { get; set; }
        public string Codigo { get; set; } = null!;
        public string NombreProveedor { get; set; } = null!;
        public string Documento { get; set; } = null!;
        public DateTime FechaDocumento { get; set; }
        public string Aplicacion { get; set; } = null!;
        public string Usuario { get; set; } = null!;
        public string Moneda { get; set; } = null!;
        public decimal Monto { get; set; }
        public decimal Saldo { get; set; }
        public string? Asiento { get; set; }
        public short? Subtipo { get; set; }
    }
}
