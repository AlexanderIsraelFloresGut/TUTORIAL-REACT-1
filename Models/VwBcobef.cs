using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class VwBcobef
    {
        public string CuentaBanco { get; set; } = null!;
        public int? Año { get; set; }
        public int? Mes { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Trx { get; set; }
        public string? PagaderoA { get; set; }
        public string Subtipo { get; set; } = null!;
        public decimal Numero { get; set; }
        public string TipoDocumento { get; set; } = null!;
        public string? Asiento { get; set; }
        public decimal Monto { get; set; }
        public string UsuarioCreacion { get; set; } = null!;
    }
}
