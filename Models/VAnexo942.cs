using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class VAnexo942
    {
        public string? Tipo { get; set; }
        public string Ruc { get; set; } = null!;
        public string? Dv { get; set; }
        public string RazonSocial { get; set; } = null!;
        public string Documento { get; set; } = null!;
        public string TipoDocumento { get; set; } = null!;
        public string Concepto { get; set; } = null!;
        public DateTime Fecha { get; set; }
        public decimal Monto { get; set; }
    }
}
