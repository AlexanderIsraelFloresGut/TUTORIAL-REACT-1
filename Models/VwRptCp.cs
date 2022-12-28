using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class VwRptCp
    {
        public string Empresa { get; set; } = null!;
        public string Proveedor { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public string Contribuyente { get; set; } = null!;
        public string Tipo { get; set; } = null!;
        public string TipoDc { get; set; } = null!;
        public DateTime FechaDocumento { get; set; }
        public string Documento { get; set; } = null!;
        public string Aplicacion { get; set; } = null!;
        public decimal? SaldoNio { get; set; }
        public decimal? SaldoDolar { get; set; }
    }
}
